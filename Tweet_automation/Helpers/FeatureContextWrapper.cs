using Coypu;
using TechTalk.SpecFlow;

namespace Tweet_automation.Helpers
{
    public static class FeatureContextWrapper
    {
        public static BrowserSession BrowserSession
        {
            get { return (BrowserSession)FeatureContext.Current["BrowserSession"]; }
            set { FeatureContext.Current.Set(value, "BrowserSession"); }
        }
    }
}
