using System;
using Coypu;

namespace Tweet_automation.Helpers
{
    public class Cleanup
    {
        public void CleanupTweet()
        {
            BrowserSession _browser = FeatureContextWrapper.BrowserSession;
            try
            {
                if (_browser.FindCss(".Icon--caretDownLight").Exists() == false)
                {
                    return;
                }
                _browser.FindCss(".Icon--caretDownLight").Click();
                _browser.ClickButton("Delete Tweet");
                _browser.ClickButton("Delete");
            }
            catch (Exception e)
            {
                Console.WriteLine("Cleaning up tweet.");
            }
        }
    }
} 
