Feature: Reqres API	Tests

Scenario Outline: Register a new User with Valid UserName and Email
When I register a new User with '<usernameState>' Username and '<passwordState>' Password
Then registration is sucessfull 
And token is generated

Examples:
| usernameState		| passwordState |
|eve.holt@reqres.in | pistol        |

Scenario Outline:Register a New User with Invalid combinations
When I register a new User with '<usernameState>' Username and '<passwordState>' Password
Then registration is not sucessfull 

Examples:
| usernameState				 | passwordState |
| qwerty				  	 | 123456789     |
| asdf@1234.com				 | pistol        |
| eve.holt@reqres.in         | |
 
Scenario: List users
When user sends a requests on 'users'
Then user gets list of users 