Feature: Automation Practice
  
  @AutomationPractice

   Scenario Outline: Invalid Login
   Given user is  on the Home page 
   When user clicks on SignIn button
   And user enters <username> and <password>
   And user click LogIn button
   Then user should see <errorMessage>
   Examples: 
   | username|password| errorMessage|
   |                    | abcdef   | An email address required. |
   | testuser@gmail.com |          | Password is required.      |
   | testuser@gmail.com | abcdef   | Authentication failed.     |
   |                    |          | An email address required. |