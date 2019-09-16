Feature: Exedia Flight Booking

@Expedia
Scenario Outline: Select Flight
       Given I am on flight booking page
       And Click user clicks on Flight section
       When I select multi-select
       Then click on Add another flight
       Then Search for flights between different airports <FIRST>,<SECOND>,<THIRD> on dates <Date1>,<Date2>,<Date3>  for <number>  adults
       Then click on Search option
	   And verify tht the data entered is correct
       And select First flight
       And Total Price must be equal to <number> multiplied fare of single person
Examples:
| FIRST	| SECOND |THIRD | Date1 | Date2    | Date3    | number |
| MLA | LON | ROME | 02/17/2020 | 02/20/2020|02/24/2020|   4    |

