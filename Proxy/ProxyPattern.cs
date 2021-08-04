using design_patterns_csharp.Proxy.Components;

namespace design_patterns_csharp.Proxy
{
    public class ProxyPattern
    {
       public void Main(){
            IBrowser browser = new FirefoxBrowser();
            IBrowser proxyBrowser = new RestrictedPagesProxyBrowser(browser);

            proxyBrowser.GoToWebPage("zvideos.com");
            proxyBrowser.GoToWebPage("facebook.com");
            proxyBrowser.GoToWebPage("laconfidential.com");
            proxyBrowser.GoToWebPage("twitter.com");



       }
    }
}