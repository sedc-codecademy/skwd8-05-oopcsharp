# Homework Class 6 📒

## Task 1
Create an ATM application. A customer should be able to authenticate with card number and pin and should be greeted with a message greeting them by full name. After that they can choose one of the following:
1) Balance checking - This should print out the current balance of money on their account
2) Cash withdrawal - This should try and withdraw cash from the users account and print a message. If it has enough it should print a success message that contains the money withdrawn and the balance of money after the withdrawal  
3) Cash deposition - This should deposit cash on the account and give a message with the new balance of money on the account after the deposit.

In order for the ATM app to work we need Customers. This ATM asks for the number ( string ) of the card and searches through the customers if a card like that exists. After that it asks for a pin. If the Pin matches that customer a welcome message is shown and the customer can now choose the options.

**Example**

Welcome to the ATM app

Please enter your card numer:

**\>** 1234-1234-1234-1234

Enter Pin:

**\>** 4325

Welcome Bob Bobsky!

What would you like to do:

1) Check Balance
2) Cash Withdrawal
3) Cash Deposit

**\>** 2

You withdrew 250\$. You have 400\$ left on your account.

Thank you for using the ATM app.
 
**Bonus:** The balance and pin should not be public

**Bonus:** The ATM card number to be a number instead of a string. The user should still input 1234-1234-1234-1234.

**Bonus:** When the Customer finishes with a transaction a question must pop up if the Customer wants to do another action. If not it should print a goodbye message and show up the login menu again.

**Bonus:** Add an option to register a new card in the system that store the customer in the system if the card number is not used for any other customer
