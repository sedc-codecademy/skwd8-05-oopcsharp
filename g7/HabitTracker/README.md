# Habit Tracker 🧬
## Introduction 📚
Creating new good habits and getting rid of the old bad ones can be a real tough job. On average a person needs 66 days to keep or avoid a habit to get it in or out of their system. Of course that is just an average. People vary in the efficiency of tackling habits. One of the ways we can improve this is to track our habits somewhere so we can better understand how much time we are doing something and where can we improve. This is where this habit tracking app comes in the picture. This console application is specifically designed for tracking habits for people that love to use the command line. Our target audience should be mainly programmers, sys-ops, dev-ops and any creature that feels comfortable typing commands instead of clicking buttons. 
## Features 📑
* Every user can login or create an account
* Every user must choose at least 1 good and bad habit to track when registering 
* The application should have validations on inputs for type ( if option 1 and 2 are available the only those two should be able to go through the validation )
* Every user should be able to record whether they completed a habit or not
* Every user should be able to see statistics about habits
* Menus after logging in should have an option to go back to the previous menu
* The application should have an option to go back to the home menu at any time
* There should be an option for exiting the application at the home menu
* When adding a habit or adding a single record there should be a question whether the user wants to add another one
* The user can change their info and password when they are logged in
* The user can add or remove habits once they are logged in
* Errors and success messages should be color coded
## Feature map 📈
* Users can register
	* Add information about the person such as:
		* Username
			* Must have at least 6 characters and must not start with a number
		* Password
			* Must have at least 6 characters and at least 1 number 
		* First Name
			* Must have at least 2 characters and must not contain any number
		* Last Name
			* Must have at least 2 characters and must not contain any number
		* Date Of Birth
			* Must calculate age and age must not be less than 5 or more than 122
	* Setup their account
		* Set at least 1 good and 1 bad habit with
			* Title - name of the habit
			* Group - in what group does the habit belong
				* Exercise and sports
				* Study and learning
				* Activities and hobbies
				* Work and career
				* Home and personal
				* Other
			* Difficulty - how difficult the habit is to follow
				* Low
				* Medium
				* Hard
			* Type - what type of habit it is
				* Good
				* Bad
* Users can login 
  * Check if user exists in "DB"
  * After 3 attempts show error and close the application
* After logging in these features should be available: 
	* Habits
		* Daily log
			* Every habit has records which are data about the habit which are:
				* Date - When the habit was recorded
				* Is Completed - Was the habit completed that day or not
			* The date should be setup as the current date
			* Add record for every habit that the user is tracking one by one
		* Single Log
			* The date is set by the user
			* The user chooses one of the habits that the user is tracking which they will add a single record
			* If there is a record in that date previously warn the user that this data will overwrite the previous data and ask them if they want to continue or go back
	* Statistics
		* Good habits
			* List all good habits and how much times were they recorded to be completed
		* Bad habits
		  * List all good habits and how much times were they recorded to be completed
		* Weekly statistics
			* This counts for the last 7 days that passed
			* For days that don't have record for some habit, it is counted as missed ( not completed )
			* Show all habits and how many times they were recorded to be completed vs not completed this week ( ex: Running 5 completed / 2 missed )
		* All time statistics
			* Percentage of Completed vs missed for every habit from all data recorded from the first date on record until today ( missing ones are counted as not completed )
	* Edit Account 
		* Add habit
			* Add another habit in the list of habits of the user
		* Remove habit
			* Remove a habit currently in the list of the user
		* Edit info
			* Edit values for First Name or Last Name
		* Change password
			* Change the current password ( need to enter the old one then the new one )
