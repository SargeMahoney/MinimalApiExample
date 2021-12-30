namespace MinimalApi.Api.StringApi

{
    public static class ExampleStringApi
    {
        public static List<string> randomStrings = new List<string>()
        {
            "John", "Marie", "Jack"
        };


        public static void StringApiConfig(this WebApplication app)
        {
            app.MapGet("/examplestring", () =>
            {
                return randomStrings;
            });
        }
    }
}
