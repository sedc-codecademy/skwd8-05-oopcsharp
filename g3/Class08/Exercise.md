## Excercise for previous classes + inheritance (Application for a Firm/Company)
* You need to use Class Library projects and put the Domain and Service classes accordingly.  
* Also you need to create an array of Employee, Products (and also subclasses) Domain objects in the main Console App
* Implementation od IDs (for Employees & Products)
* Overriding of model's methods (from Employees & Products) specific to the extended classes/models

### Firm Domains
## 1. Employee Domain
**Properties**
* ID (identificator)
* FirstName - string
* LastName - string
* Role (Manager, Worker, Sales, Finance) - Enum
* Hours (int)
* Salary (perHour-double)
* OnHoliday (bool)

**Methods**
* Constructor (that sets all the properties)
* PrintInfo (virtual) - Prints FirstName, LastName and Salary​
* GetSalary - returns the salary (double)
* SetSalary - Prints new salary, returns void

## 2. Manager, Worker, Sales, Finance Domain (extends Employee)
**Properties**
* Bonus (Sales)

**Methods**
* PrintInfo (override) - Prints FirstName, LastName and Salary * Hours​ (+ Bonus for Sales)
* GetSalary (override) - returns the Salary * Hours​ (+ Bonus for Sales)


## 1. Product Domain
**Properties**
* ID (identificator)
* Name (of product, string)
* Type (Food, Electronics, Drink) - Enum
* Price (double)
* OnPromotion (bool)

**Methods**
* Constructor (that sets all the properties)
* PrintInfo - Prints Name (of product), Type and Price​
* GetPrice - returns the price (double)
* SetPrice - Prints new price, returns void

## 2. Food, Drink, Electronics (extends Product)
**Properties** 
* Taste - (sweet, salty, sour) Enum. (Only for Food)
* Calories - (Only for Food)
* Liters - (in l). (Only for Drinks)
* IsAlcohol - (Only for Drinks)
* Voltage - (in V). (Only for Electronics)

**Methods**
* PrintInfo - (override for each Food, Drinks and Electronics)
* SetPrice - (override for each Food, Drinks and Electronics)
* TurnOn - prints a message that the electronic part is working. (Only for Electronics)
* OpenBottle - (Only for Drinks)
* ShowCalories - (Only for Food)

### The Firm Services
### 1. Employee Service
* Create an employee - return Employee object
* Get all employees by role - return array of Employees
* Add an employee to array - void
* Edit an employee in array - void
* Promote an Employee - void
* Let Employee on vacation - void
* Get all employees that have a larger salary than <number> - return array of Employees

### 1. Product Service
* Create a Food - return Food object
* Create a Drink - return Drink object
* Create a Electronics - return Electronics object
* Get all products by type - return array of Products
* Add a product to array - void
* Edit a product in array - void