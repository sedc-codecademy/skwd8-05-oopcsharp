
# **Workshop Excercise** - CompanyApp 👀

## Part 01

- Create a class library project and in it create all classes
- Create a class called `Employee` with the following `properties`:
	- FirstName
 	- LastName
  	- Role - Enum ( Sales, Manager, Other )
	- Salary - protected, double
- Create two `methods`:
	- PrintInfo - Prints FirstName, LastName and Salary
	- GetSalary - returns the salary

## Part 02

- Create a `SalesPerson` class that inherits from `Employee` and has the following properties:
	- SuccessSaleRevenue double, private
The salary is by default 500 and role is default Sales
- Create constructor that sets all the properties
- Create a method called `ExtendSuccessRevenue` that will get a number and set the `SuccessSaleRevenue` to that value
- Override the `GetSalary` method to return the value of the salary plus bonus that is calculated by the `SuccessSaleRevenue`. 
	- If less or equal to 2000 then add 500 bonus
	- If larger than 2000 but less or equal than 5000 then add 800 bonus
	- If larger than 5000 add 2000 bonus

## Part 03

- Add class `Manager` that inherits from `Employee` and has a new property called `Bonus` - double, private
- Create a constructor that sets all properties except `Bonus`
- Create a method called `AddBonus` that adds bonus to the `Bonus` property
- Override the method `GetSalary` to return the Salary + Bonus

### *Create one manager and add bonus to his salary, then print the salary.* 🤓
### *Create 3 sales people and extend their revenue, then print their salaries.* 🤯

### **Bonus** 😍

### *Add a class called `Contractor` that inherits from `Employee`. The employee should have properties: *
- WorkHours ( double ), 
- PayPerHour ( int ) and
- Responsible (Manager ( object )).

### *The `GetSalary` method should be overridden to return `WorkHours * PayPerHour` and also change the `Salary` property to that amount*
