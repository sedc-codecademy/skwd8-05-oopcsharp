# Homework Class 3 📒

## Task 1
Create a class Animal that will hold the following properties and methods:
1. Name
2. Spicie
3. Color
4. FavouriteFoods
5. Eat => Method that will take an input parameter "food", and will display a message: "#Name the #Specie wants to eat #food"
5. Sleep => a method that will take two input parameters, "from" and "till" and should display the message: "#Name the #Specie sleeps from #from till #till"

***Note: Make sure that whenever a new object is created, FavouriteFoods property should be already filled with 'Meat' and 'Snacks'**

## Task 2
Extend the class from Task 1 with another property Owner, which should be of type Owner :).
The Owner should have:
1. FirstName
2. LastName
3. Age 
4. Address
5. Pets => array of pets
5. City
6. FullInfo() => method which should display: "#FirstName #LastName, lives in the city of #City on address #Address"

## Task 3 
Create an array that will serve as a pet shelter, and will contain 5 animals in it. Ask the user to enter firstname, lastname, city and address. Create a new owner, and give him an option to adopt one or more pets **(only if it is more than 18 years old)**, by displaing to him all the pets from the shelter with numbers in front of them like:
1. Bill the dog
2. Jane the cat....
and so on. Give him the chance to select until he/she inputs "N", that its enough :)
While selecting the pets, add them to the "Pets" property to that owner. After he/she enter "N" that the process of adopting should stop. Display the message: "Thank you Mrs/Mr #Name, please keep your pets save and love them! Here are your pets:" and display them all with their names and spicies.

**Note:**
**Make sure to wrap up the business logic into separate methods.**
**It would be nice if you can split the classes in a separate folder, and make the project structure more clear**