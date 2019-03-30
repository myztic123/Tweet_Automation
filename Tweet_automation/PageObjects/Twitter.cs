using TechTalk.SpecFlow;

namespace Tweet_automation.PageObjects
{
    public static class Twitter
    {
        public static LoginPage LoginPage
        {
            get { return (LoginPage) ScenarioContext.Current["LoginPage"]; }
            set { ScenarioContext.Current.Set(value, "LoginPage"); }
        }

        public static HomePage HomePage
        {
            get { return (HomePage) ScenarioContext.Current["HomePage"]; }
            set { ScenarioContext.Current.Set(value, "HomePage"); }
        }
    }
}