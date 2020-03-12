# Heroes Journey ⚔

## Part 1: Log in the game 🛡
* The users can log in with their email and passwords
* Research how to find a character in a string
* Find a way to keep the emails and passwords
  > Proposal: Create an array with two emails and an array with two passwords
* Ask the user to enter username and then password
* Validate the inputs
	* Fields must not be empty
	* The email and password must match with the corresponding email and password that were added previously
	* The email filed should be validated by checking if there is **@** character and a **.** character
	* In case the input is wrong give the user an option to try again
	* After 5 tries, close the application
* When the user logs in show a Welcome message

## Part2: Create a character 🗡
* The user needs to input a name
	* The name must be longer than 1 characters
	* The name must not be longer than 20 characters
* Give the options to the user to choose from 3 races:
	* 1 ) Dwarf
		* Has 100 Health
		* Has 6 Strength
		* Has 2 Agility
	* 2 ) Elf
		* Has 60 Health
		* Has 4 Strength
		* Has 6 Agility
	* 3 )Human
		* Has 80 Health
		* Has 5 Strength
		* Has 4 Agility
	* Validate the answer, if it is not a number or a number that is not given as an option, show an error message and give the options again
* After that give the user an option to choose a class:
	* 1 ) Warrior
		* +20 Health
		* -1 Agility
	* 2 ) Rogue
		* -20 Health
		* +1 Agility
	* 3 ) Mage
		* +20 health
		* -1 Strength
	* Validate the answer, if it is not a number or a number that is not given as an option, show an error message and give the options again
* A message for successful creating of the character must be shown
* A review of the character stats must be shown:
	* 'name' ( 'race' ) the 'class' 
		> **Ex:** Bob ( Dwarf ) the Warrior
	* Stats: 'health' HP, 'strength' STR, 'agility' AGI
	    > **Ex:** 120 HP, 6 STR, 1 AGI  
## Part 3: Gameplay 🏹
* Research how to get random numbers in C#
* The hero should pass 5 events to win the game
* When an event happens:
	* Description of the event shows 
	* The hero has an option to:
		* 1 ) Fight - Get a random number from 1 to 10 and if that number is lesser than your Strength then you win the fight with a message showing: You won fight!
		* 2 ) Run Away - Get a random number from 1 to 10 and if that number is lesser than your Agility then you run away
		* The user should not be able to enter anything other than 1 or 2
	* Events take health off the character if it fails
	* Different events take different amount of health
	* When the health is subtracted from the character health there must be a check made to see if the character health is below or equal to 0
	* If the character health is equal of below zero, show a YOU LOST message and ask the person if they want to start a new game
		* 1 ) Yes - Restarts the game 
		* 2 ) No - Exits the application
	* If the character has more health, show how much health is left and go to the next event
	* After the last event if the character has more than 0 health, show a YOU WON message and ask the person if they want to start a new game, the same as when you lose options of Yes and No
* Events:
	* Bandits attack you out of nowhere. They seem very dangerous...
		* -20 health
	* You bump in to one of the guards of the nearby village. They attack you without warning...
		* -30 health
	* A Land Shark appears. It starts chasing you down to eat you...
		* -50 health
	* You accidentally step on a rat. His friends are not happy. They attack... 
		* -10 health 
	* You find a huge rock. It comes alive somehow and tries to smash you...
		* -30 health 
		
## Testing out the game
There is a game already uploaded in a .zip file. Unzip it and play it to see how the game looks. 
* Email: bob22@mail.com
* Password: bobbest
