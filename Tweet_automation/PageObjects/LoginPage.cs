using System.Configuration;
using Coypu;
using Tweet_automation.Helpers;

namespace Tweet_automation.PageObjects
{
    public class LoginPage
    {
        private readonly BrowserSession _browser = FeatureContextWrapper.BrowserSession;

        public void Navigate()
        {
            _browser.Visit(ConfigurationManager.AppSettings["Url"]);
        }

        public void Login()
        {
            _browser.FindCss(".StaticLoggedOutHomePage-buttonLogin").Click();
            _browser.FindCss(".js-username-field").FillInWith(ConfigurationManager.AppSettings["Email"]);
            _browser.FindCss(".js-password-field").FillInWith(ConfigurationManager.AppSettings["Password"]);
            _browser.ClickButton("Log in");
        }

    }
}
