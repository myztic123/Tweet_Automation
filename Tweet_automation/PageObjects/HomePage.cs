using Coypu;
using NUnit.Framework;
using Tweet_automation.Helpers;

namespace Tweet_automation.PageObjects
{
    public class HomePage
    {
        private readonly BrowserSession _browser = FeatureContextWrapper.BrowserSession;
        public void TypeTweet(string tweetText)
        {
            _browser.FindId("tweet-box-home-timeline").FillInWith(tweetText);
        }

        public void TypeTweetAgain(string tweetText)
        {
            _browser.ClickLink("home timeline");
            _browser.FindId("tweet-box-home-timeline").FillInWith(tweetText);
        }

        public void PostTweet()
        {
            _browser.FindCss(".tweeting-text").Click();
        }

        public void ValidateNewTweet(string tweetText)
        {
            string actualText = _browser.FindCss(".tweet-text").Text;
            Assert.AreEqual(tweetText, actualText);
        }

        public void ValidateOptions(string option)
        {
            string optionElement = null;
            switch (option)
            {
                case "reply":
                    optionElement = ".Icon--reply";
                    break;
                case "retweet":
                    optionElement = ".Icon--retweet";
                    break;
                case "like":
                    optionElement = ".HeartAnimation";
                    break;
                case "view tweet activity":
                    optionElement = ".Icon--analytics";
                    break;
            }

            Assert.IsTrue(_browser.FindCss(optionElement).Exists(), $"The option '{option}' is not detected.");
        }

        public void ValidateDeleteTweet()
        {
            _browser.FindCss(".Icon--caretDownLight").Click();
            _browser.ClickButton("Delete Tweet");
            _browser.ClickButton("Delete");
            Assert.IsTrue(_browser.FindCss(".HomeEmptyTimeline-header").Exists(), "Tweet has not been deleted.");
        }

        public void CheckTweetButton()
        {
            Assert.IsTrue(_browser.FindCss(".js-tweet-btn.disabled").Exists(), "Tweet button is not disabled.");
        }

        public void CheckTweetCounter()
        {
            string tweetCounter = _browser.FindCss(".tweet-counter").Text;
            Assert.Less(int.Parse(tweetCounter), 0);
        }

        public void ValidateRepeatNotification()
        {
            string tweetNotification = _browser.FindCss(".message-text").Text;
            StringAssert.AreEqualIgnoringCase("You have already sent this Tweet.", tweetNotification);
        }

        public void DismissNotification()
        {
            _browser.FindCss(".Icon.Icon--close.Icon--medium.dismiss").Click();
        }
    }
}
