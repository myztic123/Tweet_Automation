using TechTalk.SpecFlow;
using Tweet_automation.PageObjects;

namespace Tweet_automation.Step_Definitions
{
    [Binding]
    public sealed class PostNewTweetSteps
    {
        [Given(@"I have logged into Twitter")]
        public void GivenIHaveLoggedIntoTwitter()
        {
            Twitter.LoginPage.Navigate();
            Twitter.LoginPage.Login();
        }

        [When(@"I type a tweet (.*)")]
        public void WhenITypeATweet(string tweetText)
        {
            Twitter.HomePage.TypeTweet(tweetText);
        }

        [When(@"I post a tweet")]
        public void WhenIPostATweet()
        {
            Twitter.HomePage.PostTweet();
        }

        [When(@"I type the same tweet (.*)")]
        public void WhenITypeTheSameTweet(string tweetText)
        {
            Twitter.HomePage.TypeTweetAgain(tweetText);
        }


        [Then(@"the (.*) post appears on my home page")]
        public void ThenThePostAppearsOnMyHomePage(string tweetText)
        {
            Twitter.HomePage.ValidateNewTweet(tweetText);
        }

        [Then(@"there is an option to (.*)")]
        public void ThenThereIsAnOption(string option)
        {
            Twitter.HomePage.ValidateOptions(option);
        }

        [Then(@"I can delete my tweet")]
        public void ThenICanDeleteMyTweet()
        {
            Twitter.HomePage.ValidateDeleteTweet();
        }

        [Then(@"I get a notification of a repeat tweet")]
        public void ThenIGetANotificationOfARepeatTweet()
        {
            Twitter.HomePage.ValidateRepeatNotification();
            Twitter.HomePage.DismissNotification();
        }
    }
}
