# Homework Class 8 📒

## Task 1
* Create a SalesPerson class that inherits from Employee and has the following properties:
  * SuccessSaleRevenue double, private
  * The salary is by default 500 and role is default Sales
* Create constructor that sets all the properties
* Create a method called AddSuccessRevenue that will get a number and set the SuccessSaleRevenue to that value
* Override the GetSalary method to return the value of the salary plus bonus that is calculated by the SuccessSaleRevenue. 
  * If less or equal to 2000 then add 500 bonus
  * If larger than 2000 but less or equal than 5000 then add 1000 bonus
  * If larger than 5000 add 1500 bonus

## Task 2
* Add class Manager that inherits from Employee and has a new property called Bonus - double, private
* Create a constructor that sets all properties except Bonus
* Create a method called AddBonus that adds bonus to the Bonus property
* Override the method GetSalary to return the Salary + Bonus

## Task 3
Extend the exercise for Employees with two more Employees. Add a class called Contractor that inherits from Employee. The employee should have properties: WorkHours ( double ), PayPerHour ( int ) and Responsible (Manager ( object )).
* The GetSalary method should be overridden to return WorkHours * PayPerHour and also change the Salary property to that amount 
* A new method called CurrentPosition should return the department of the manager that is responsible for this Contractor