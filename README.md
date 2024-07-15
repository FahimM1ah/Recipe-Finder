# GruppeSec Recipe Finder

GruppeSec Recipe Finder is a Windows Forms application that helps you find recipes based on the ingredients you have. It uses the Edamam API to search for recipes and displays the results in a user-friendly interface.

## Features

- **Ingredient Management**: Add and clear ingredients easily.
- **Recipe Search**: Find recipes using the Edamam API based on the provided ingredients.
- **Recipe Display**: Display recipe names and URLs in a new window.

## Skills Utilized

- **C# Programming**: Core language used for application logic and API integration.
- **Windows Forms**: Used for creating the graphical user interface.
- **HTTP Client**: Utilized `HttpClient` for making API requests.
- **Asynchronous Programming**: Implemented asynchronous API calls using `async` and `await`.
- **JSON Parsing**: Parsed JSON responses from the API using `Newtonsoft.Json`.

## How to Use

1. **Add ingredients**:
   - Enter an ingredient in the text box and click the `Add` button.

2. **Search for recipes**:
   - Click the `Find Recipe` button to search for recipes based on the added ingredients.

3. **View recipes**:
   - The results will be displayed in a message box, showing the recipe names and URLs.

The application uses my Edamam API key, so you can run it as-is after compiling. The code handles the interaction with the API and displays the results directly within the application.

[image](https://github.com/user-attachments/assets/96718355-9fe6-4824-981a-f76a2aded955)

