using Tweet_automation.Helpers;
using Tweet_automation.PageObjects;
using TechTalk.SpecFlow;

namespace Tweet_automation
{
    [Binding]
    public sealed class Hooks1
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            FeatureContextWrapper.BrowserSession = BrowserFactory.GetBrowser();

            Twitter.LoginPage = new LoginPage();
            Twitter.HomePage = new HomePage();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            new Cleanup().CleanupTweet();
            FeatureContextWrapper.BrowserSession.Dispose();
        }
    }
}