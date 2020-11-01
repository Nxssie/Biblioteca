#Biblioteca
This C# app connects with a database to manage users (students) of an imaginary school library.

## Installation steps :gear:
1. Clone this repository.
2. You'll need 'libros' database. (private content)
    * You could adapt this solution to your environment. It's easy! :yum:
3. Open this solution in your IDE
4. Run your MySql server.
5. Go to [Connection class](https://github.com/Nxssie/Biblioteca/blob/master/ModelProject/Connection.cs) and set the necessary params to connect with the database.
6. Run the solution.

## Summary :paperclip:
This solution is built following the MVC as the design pattern. Excepting some events handlers 
in the views. It means that the controllers never directly access to the Database. It goes 
through some Model methods that interacts with the data and return that information to the 
Controller. The Views are only to design User Interfaces, in any case a View will perform actions
that exceed this purpose.

## Built With :wrench:
* Visual Studio Community 2019.
* MySql (or Xampp).

## Acknowledgments :bookmark:
* [Clean Code: A Handbook of Agile Software Craftsmanship - Robert C. Martin ](https://www.amazon.es/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882)
* [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [StackOverflow C# Community](https://stackoverflow.com/questions/tagged/c%23)

## Dev notes :memo:
Referencing to a View handling events to perform actions from a button. This is a project coded
(in some stages hardcoded :zany_face:) in 4-5 days. There are too many things that a Senior Developer
will found as crazy Junior things but I think It's understandable bearing in mind how big could be a project
of this features and the reduced time we had to do it. Thanks for reading and feel free to help
us to resolve as many issues you find and as many as tips this community can give us to improve