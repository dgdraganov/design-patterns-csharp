namespace design_patterns_csharp.Proxy.Components
{
    public class FirefoxBrowser : IBrowser
    {
        public void GoToWebPage(string webPage)
        {
            System.Console.WriteLine($"Contents of web page {webPage}: <html>...</html>");
        }
    }
}