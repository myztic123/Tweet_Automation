using Coypu;
using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using System;
using System.Configuration;

namespace Tweet_automation.Helpers
{
    public static class BrowserFactory
    {
        public static BrowserSession GetBrowser()
        {
            var browserName = ConfigurationManager.AppSettings["Browser"];
            Browser browser = Browser.Parse(browserName);
            BrowserSession browserSession;

            var sessionConfiguration = new SessionConfiguration()
            {
                Driver = typeof(SeleniumWebDriver),
                Browser = browser,
                RetryInterval = TimeSpan.FromSeconds(0.5),
                Timeout = TimeSpan.FromSeconds(10)
            };

            browserSession = new BrowserSession(sessionConfiguration);
            browserSession.MaximiseWindow();
            return browserSession;
        }

    }
}