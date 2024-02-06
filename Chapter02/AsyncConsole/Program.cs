namespace AsyncConsole
{
    internal class Program
    {
         static async Task Main(string[] args)
        {
            HttpClient client = new();

            HttpResponseMessage response = await client.GetAsync("http://www.apple.com");

            WriteLine($"Apple's home page has {response.Content.Headers.ContentLength} bytes");
        }
    }
}
