Feature: PostNewTweet
	In order to be active in social media
	As a twitter user
	I want to be able to start conversations

Background: 
	Given I have logged into Twitter

Scenario Outline: Post a new tweet less than 280 chars
	When I type a tweet <tweet>
	And I post a tweet
	Then the <tweet> post appears on my home page
	And there is an option to reply
	And there is an option to retweet
	And there is an option to like
	And there is an option to view tweet activity
	And I can delete my tweet

	Examples: 
	| tweet                                                                                                                                                                                                                                                                                            |
	| "Daenerys of the House Targaryen, the First of Her Name, The Unburnt, Queen of the Andals, the Rhoynar and the First Men, Queen of Meereen, Khaleesi of the Great Grass Sea, Protector of the Realm, Lady Regnant of the Seven Kingdoms, Breaker of Chains and Mother of Dragons." GOT |
