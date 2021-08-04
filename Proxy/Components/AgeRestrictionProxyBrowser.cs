using System.Collections.Generic;

namespace design_patterns_csharp.Proxy.Components
{
    public class RestrictedPagesProxyBrowser : IBrowser
    {

        public RestrictedPagesProxyBrowser(IBrowser realBrowser)
        {
            RealBrowser = realBrowser;
            RestrictedAccessPages = new HashSet<string>();
            RestrictedAccessPages.Add("websecrets.com");
            RestrictedAccessPages.Add("laconfidential.com");
            RestrictedAccessPages.Add("zvideos.com");
        }

        private IBrowser RealBrowser { get; }
        private ICollection<string> RestrictedAccessPages { get; }

        public void GoToWebPage(string webPage)
        {
            if (this.RestrictedAccessPages.Contains(webPage))
            {
                System.Console.WriteLine($"ERROR: *Access to '{webPage}' is restricted for your area!*");
                return;
            }

            this.RealBrowser.GoToWebPage(webPage);
        }
    }
}