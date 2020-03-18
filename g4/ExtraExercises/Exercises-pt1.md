# Exercises - part 01

### 1. Create a new project (console .net core app) called trafficLight.

- Simulate a traffic light. There should be 3 lines, in first should be printed "STOP" and colored in red, in second should be printed
  "READY" and colored in yellow and finally in third should be printed "GO" and colored in green.
* Hint: Console has many more methods like WriteLn and ReadLn. You can set the background color with one of them, but note that you need
  first to set color and then to print the message on the screen.

Sample output:

![image](https://user-images.githubusercontent.com/45940739/75863764-4ee79700-5e01-11ea-9469-3f33d48ae40e.png)

### 2. Create a new project (console .net core app) called fizzbuzz.

- Write a short program that prints each number from 1 to 100 on a new line.
- For each number that is divided by 3 print “Fizz” instead of the number.
- For each number that is divided by 5 print “Buzz” instead of the number.
- For each number that is divided by 3 and 5  print “Fizz-Buzz” instead of the number.
* Bonus: Print "fizz" and "buzz" (or both) in different colors in console.

Sample output:
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
Fizz-Buzz
...

###  3. Create a new project (console .net core app) called digitComparer.
- Write a program that will print out **all** two-digit numbers, which have the first digit greater than 	the second digit.
Sample output:
10
20
21
30
31
32
40
41
42
43
50
51
52
53
54
...

### 4. Return name of month 🗓️
As the user to enter a number from 1-12, and print the month name correcponding to that number:
Examples:
3 ➞ "March"
12 ➞ "December"
6 ➞ "June"
When the user enters anything else that is not a number from 1 to 12, write "Error, incorrect value", and ask the user to enter a proper value.


### 5. Coffe machine ☕
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
