# Exercises for identifying and enhancing C# skills 💪
___

### 1. Flip the boolean 🙃
Write a console application that will ask the user to enter true or false.
When the user enters "true", flip the boolean and write false in the console. When the user enters "false", flip the boolean and write true in the console. When the user enters anything else, write "Error, incorrect value", and ask the user to enter true or false.

### 2. Multiple of 100 ✖️
Ask the user to enter a number. When the number the user enters, is divisible by 100, print "You have entered a cool number!", otherwise print "The number you've enterd is not cool at all!" in the console. When the user enters anything else that is not a number, write "Can't you read? Enter a number, not anything else!", and ask the user to enter a proper number.

### 3. Return name of month 🗓️
As the user to enter a number from 1-12, and print the month name correcponding to that number:
Examples:
3 ➞ "March"
12 ➞ "December"
6 ➞ "June"
When the user enters anything else that is not a number from 1 to 12, write "Error, incorrect value", and ask the user to enter a proper value.

### 4. Profitable Gamble 🎰
Ask the user to enter three things, one by one: prob, prize, pay and returns "You won!" if **prob * prize > pay**, otherwise return false. To illustrate, 0.2, 50, 9 should yield "You won!", since the net profit is **1 (0.2 * 50 - 9), and 1 > 0**.
Examples
(0.2, 50, 9) ➞  You won!
(0.9, 1, 2) ➞  You loose!
**Notes
A profitable gamble is a game that yields a positive net profit, where net profit is calculated in the following manner: net_outcome = probability_of_winning * prize - cost_of_playing.**

### 5. The Farm Problem 🐔
Create a consoel application that will help a farmer to count how many legs he has among all his animals(enter each value one by one via the console readline). The farmer breeds three species:
chickens = 2 legs
cows = 4 legs
pigs = 4 legs
The farmer has counted his animals and he gives you a subtotal for each species. You need to print out the total number of legs of all the animals.
Examples:
(2, 3, 5) ➞ 36
(1, 2, 3) ➞ 22
(5, 2, 8) ➞ 50
Notes:
The order of animals passed is animals:
- chickens, 
- cows,
- pigs.
-
**Remember that the farmer wants to know the total number of legs and not the total number of animals.**

### 6. Word count 🖖
Create a console app that when entered a string you print out the word count. The string will be a sentence.
Examples:
"Just an example here move along" ➞ 6
"This is a test" ➞ 4
"What an easy task, right" ➞ 5
**Notes:
Remember how we did this in JavaScript? Don't worry, it's very similar :)**

### For the bravest!
### 7. Liquor store 🥂
Create a console application, that will serve as a Liquor store. Display a welcome message first, and then ask the user for his/her ID Card, by requesting its firstName, lastName and age. If the user is more than or equal to 18 years old, than ask him what kind of drink he wants to buy. After that display the following message: "Dear #firstName #lastName, here you are a bottle of #drinkName, have a nice day!". If the user is less than 18 years old, display the following message: "Dear #firstName #lastName, I am sorry but you are not allowed to buy alchocol". Make sure that the user enters the right input, if not display an appropriate message: "Please enter a valid input!"

### 8. Coffe machine ☕
Create a console application that will work as a coffee machine. The application should start with message displayed first, "Welcome dear customer, please select a drink:". Allow the user to select its drink, and after selection give him an option for selecting sweetnes level "1-5". After that ask him to input money as the drink costs. Check if he enters enough to buy the drink, if he inputs less, display a message "The drink costs #drinkPrice, you are missing #left money to buy it", and give him an option to enter again.
```
Welcome dearu customer! Please select a drink:
1. Espresso...........2$
2. Macchiato........3,5$
3. Latte..............4$
4. Cappuccino.........6$
5. Tea..............1.5$
Ex.
Input  => User choose 2
Output => Please insert 3,5$
Input  => 2
Output => The macchiato costs 3,5$, you are missing 0.5$ to buy it
```
### 9. Future prediction 🔮
Create a future prediction console application that will display the user one of the following messages: 
"You got a jackpot 1.000.000EUR", 
"You will lost weights", 
"Your boyfriend will break up with you!", 
"Your cousine will buy you a dog!", 
"You will leave 100 years!"
** **Research how to generate a random number from 1-5 in C#** **
### 10. Farenheit to Celsius conversion🌡️
Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. Go to the editor
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86




