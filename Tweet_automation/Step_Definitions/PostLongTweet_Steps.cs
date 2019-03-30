using TechTalk.SpecFlow;
using Tweet_automation.PageObjects;

namespace Tweet_automation.Step_Definitions
{
    [Binding]
    public sealed class PostLongTweetSteps
    {
        [Then(@"I am unable to post it")]
        public void ThenIAmUnableToPostIt()
        {
            Twitter.HomePage.CheckTweetButton();
        }

        [Then(@"the tweet counter is less than 0")]
        public void ThenTheTweetCounterIsLessThan0()
        {
            Twitter.HomePage.CheckTweetCounter();
        }

    }
}
