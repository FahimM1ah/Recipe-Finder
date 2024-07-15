using System.Text;

namespace GruppeSecRF
{
    public partial class MainForm : Form
    {
        private List<string> ingredientList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            APIHelper.initializeClient();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ingredientList.Clear();
            ingredientTextBox.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string ingredient = ingredientTextBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(ingredient))
            {
                ingredientList.Add(ingredient);
                ingredientTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an ingredient.");
            }
        }

        private void clearFieldButton_Click(object sender, EventArgs e)
        {
            ingredientTextBox.Clear();
        }

        private async void FindRecipeButton_Click(object sender, EventArgs e)
        {
            string appId = "c2040f83";
            string appKey = "dabd3bdb34d7f3270db7360bf27dadd9";
            string[] ingredients = ingredientList.ToArray();
            try
            {
                List<Recipe> recipes = await APIHelper.SearchRecipesByIngredientsAsync(ingredients, appId, appKey);
                DisplayRecipes(recipes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayRecipes(List<Recipe> recipes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Recipe recipe in recipes)
            {
                sb.AppendLine($"Recipe Name: {recipe.Label}");
                sb.AppendLine($"Recipe URL: {recipe.Url}");
                sb.AppendLine(); // add empty line between recipes
            }

            // display the recipes in a MessageBox
            MessageBox.Show(sb.ToString(), "Recipes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
