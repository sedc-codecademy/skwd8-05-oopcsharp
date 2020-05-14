# Homework Class15

## Repeat the whole implementation that we currently have for User, but not for Admin, what does this mean?

* Create Admin model with few properties
* In Fake_Database create also a method that will return a list of Admins with at least 5 Admins.
* In DB class create also a property of type List of Admins and set the value directly like we do for users,
  but now call the new method that you have created which is retreiving list of admins.
* Create Admin service simillar like the one we have for User service
* In FakeFacebook console app in main method try to perform all actions that we performed for users,
  but again do that for admins.
* For logging the exceptions in file in Logger class you can add extra method called AdminExceptionLogger
  with the same implementation for UserExceptionsLogger and in main method in catch blocks you can use
  that one. (The main point is that you will write all the code by yourself which in some way, better said
  in all ways will give you a routine in writing code)
* Try to implement your custom exception in Exceptions folder so you will be able to throw it in specific
  scenarios that you want ( of course you can use the same scenario like we have in user service)
