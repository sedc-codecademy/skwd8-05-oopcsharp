# Homework: Movie Store
## Part 2
Create a console application that will help a local Movie store to manage its work. There should
be two types of users: Employee and User. Each of them can login
1. Further the Employee can:
a. See all the registered members in the movie store
b. See all the movies available for renting (if a movie is rented, display * sign next it)
c. Add new members
d. Delete existing members
2. The User can:
a. Login if there are existing users that are registered
b. Register, by providing all the information requested: FirstName, LastName etc.
b. See its info so that it can check its subscription type and how long it has until
expiration of membership
c. Select a movie from the list so that it can borrow for watching. The already rented movies should have * sign next to them, so he/she can know that they are not available.
d. See all the rented movies that he owes to the movie store

Taking all of this into consideration you should implement the following tasks

**Important**

**There should be a minor change in the Salary property of the employee. Basically you should have a default value for the Salary, and then to calculate the salary according to the Bonus property. If there is a bonus, then sum them up, if not then the Salary stays as default.**

Okay, now when you have implemented the first part of the MovieStore application, it is expected that you already have the main pillars of your app. You have structured your application into separate folders, or maybe even better in a separate Class libraries. 
Beside that, you have implemented the domain classes for the entities that are part from the application. 
Well now, the tasks of this second part of the homework are not explained in details like the first part. That is because now, you should try to put yourself in a shoes of a developer. You should make a decisions, you should think of all the methods needed, and think about what you will need and when.

**Anyway, don't forget that you have all the functionalities explained above, where it is specified what the employee and what the user can do within this app.**

Well, happy coding then! 😎

### Task 1
Create the needed service classes so that the appropriate methods for the purpose of the business logic can be implemented.
Here you should think about weather you will have one MemberService or you will have two separate UserService and EmployeeService. After you decide this, implement all the methods that have to deal with the member (employee and user)


### Task 2
Create a service, that will contain all the methods that you will need for some common operations. Here you should think of, any kind of validation methods, error handling methods and so on. 
**Reference: if you want to remind yourself, check the LibraryApp on github that we are building during the exercises classes.**

### Task 3
When you are done with the implementation of the services, it's time for the interaction part, where you will implement the logic of how should the whole workflow go. Here you should think of what will be required from the user and how those inputs will be used. 
* Try to implement an infinite workflow, so that the user is able to do more things that he/she wants until 'n' is entered. 


**Note: If you can't figure out which methods and into which service you're gonna need, then scroll a little bit up in the description section, and check all the functionalities that the Employee and User should have.**