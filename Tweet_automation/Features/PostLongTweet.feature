Feature: PostLongTweet
	In order to share my views
	As a twitter user
	I want to be able post long tweets

Background: 
	Given I have logged into Twitter

Scenario Outline: Disallow posting a tweet more than 280 chars
	When I type a tweet <tweet>
	Then I am unable to post it
	And the tweet counter is less than 0

	Examples: 
	| tweet                                                                                                                                                                                                                                                                                                      |
	| Sometimes we make the process more complicated than we need to. We will never make a journey of a thousand miles by fretting about how long it will take or how hard it will be. We make the journey by taking each day step by step and then repeating it again and again until we reach our destination. |
