# DotNet Learning

# Implementing the Repository and Unit of Work Patterns in an ASP.NET MVC Application

## There are many ways to implement the repository and unit of work patterns. 
#### You can use repository classes with or without a unit of work class. 
#### You can implement a single repository for all entity types, or one for each type. 
#### If you implement one for each type, you can use separate classes, a generic base class and derived classes, or an abstract base class and derived classes. 
#### You can include business logic in your repository or restrict it to data access logic. You can also build an abstraction layer into your database context class by using IDbSet interfaces there instead of DbSet types for your entity sets. 
