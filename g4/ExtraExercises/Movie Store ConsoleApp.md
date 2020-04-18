# **Homework: Movie Store**  🎥 

## Part 1 👀

Create a console application that will help a local Movie store to manage its work. There should be **two** types of **users**:
`Employee` and `User`. Each of them can login to the app
*	**Further the Employee can:**
    *	See all the registered members in the movie store
    *	See all the movies available for renting (if a movie is rented, don’t display it)
    *	Add new members
    *	Delete existing members
*	**The User can:**
    *	Login only, after the employee register him previously
    *	See its info so that it can check its subscription type and how long it has until expiration of membership
    *	Select a movie from the list so that it can borrow for watching
    *	See all the rented movies that he owes to the movie store

***Taking all of this into consideration you should implement the following tasks***

#### **Important** 📢

Before starting the implementation of the things, take into consideration the structure of the project. I encourage you to split the concerns so that we can have a more decoupled code, which will be more easily to maintain or definitely to expand. It will grow for sure, that will be part 2 of this homework. 
So it will be super nice if you do your best and try to implement it by separating the domain classes, and the services in future into separate projects (class libraries). 
If you are not comfortable with that, then use an ordinary folder structure.



##### Well, happy coding then 😎
&nbsp;

---

### Task 1
**Create a `Member` class that will hold all the following properties, which are common for every user:**
*	`FirstName`
*	`LastName`
*	`Age`
*	`UserName`
*	`Password`
*	`PhoneNumber`
*	`DateOfRegistration`
*	`Role` => enum or class (it’s up to you)
*	`DisplayInfo` => Method that will display info about every user, in format:

   ○	1. #firstName #lastName | Registered on: #dateOfRegistration

&nbsp; 

### Task 2

Create the classes `Employee` and `User` which will inherit from the `Member` class and will have its own properties and methods. Make sure they have `constructors` with all the properties from the parent constructor plus their own, if they are not private (use base)
##### *Employee*
* `Salary` => not accessible property from outside, which should have default value when instantiating an object from Employee class of 300 eur
* `HoursPerMonth`
* `Bonus`
* `SetBonus` => method that will dynamically set Bonus to the Employee by checking: 
if the employee has HoursPerMonth > 160 hours it should be 30% (0.3)
If the employee has HoursPerMonth < 160 then it should be set to null (check nullable integer)
* `SetSalary` => method that should set the value to the Salary property by doing the multiplication of HoursPerMonth * Bonus
##### *User*
* `MemberNumber` (something like an ID) 
* `TypeOfSubscription` (Monthly, Annually) => enum or class (it’s up to you)
* `Movies` => array of Movie type 

&nbsp;

### Task 3
Create class `Movie` that will have the following properties
* `Title`
* `Description`
* `Year`
* `Genre` => enum 
* `Price` => private property 
* `SetPrice` => method that should set the price based on the Year property:
 If the Year is below 2000 the price should be a random number between 100-200
 If the Year is between 2000 and 2010 the price should be random number between 200-300
 If the Year is above 2010 the price should be random number between 300-500

