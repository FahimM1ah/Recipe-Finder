using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json.Nodes;
using Newtonsoft.Json;

namespace GruppeSecRF
{
    public class APIHelper
    {
        private static readonly HttpClient ApiClient = new HttpClient();

        public static void initializeClient()
        {
            ApiClient.BaseAddress = new Uri("https://api.edamam.com");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<List<Recipe>> SearchRecipesByIngredientsAsync(string[] ingredients, string appId, string appKey)
        {
            string ingredientsQuery = string.Join(",", ingredients);
            string requestUrl = $"/api/recipes/v2?type=any&q={ingredientsQuery}&app_id={appId}&app_key={appKey}";
            HttpResponseMessage response = await ApiClient.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(responseBody);
                List<Recipe> recipes = new List<Recipe>();

                foreach (var hit in result.hits)
                {
                    string label = hit.recipe.label;
                    string url = hit.recipe.url;
                    Recipe recipe = new Recipe { Label = label, Url = url };
                    recipes.Add(recipe);
                }
                return recipes;
            }
            else
            {
                throw new Exception($"Failed to get response from API. Status code: {response.StatusCode}");
            }
        }
    }
}