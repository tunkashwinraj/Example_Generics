Project: Generics in C#
Overview
This project demonstrates the power of generics in C# by providing various examples of how to use generic methods, classes, and collections. Generics enable you to write code that can work with any data type while maintaining type safety, reusability, and performance optimization. The project includes methods for swapping values, creating generic classes for handling multiple data types, working with arrays of reference types, and leveraging generic collections like List and Dictionary. It also showcases how to implement extension methods to add functionality to existing classes.

Features
Generic Methods: The project demonstrates how to write methods that can operate on different data types using a single generic method. It includes an example where the Exchange method can swap values of any data type, such as int, double, and custom types.

Generic Classes: The project includes a generic class MyGen<T1, T2>, which can store two values of different types and return a string representation of those values. It also demonstrates a more practical use case with a class to initialize arrays of any reference type (e.g., Student or Employee objects).

Generic Collections: The project showcases the use of List<T> and Dictionary<TKey, TValue> as more type-safe alternatives to ArrayList and Hashtable. It demonstrates how to store, retrieve, and manipulate objects in these collections, with a specific example of storing Student objects in a dictionary and retrieving them using a key.

Finding Maximum Values: The project includes a method FindMax<T>, which uses a generic approach to find the maximum value in an array of objects. To make this work, the objects must implement the IComparable<T> interface. An example using a Student class is provided to find the student with the highest test score.

Extension Methods: Extension methods are demonstrated by adding a new method to the Employee class without modifying its source code. This enables us to add functionality to existing classes in a clean and maintainable way.

Requirements
Visual Studio or any C# IDE
.NET Framework or .NET Core
Setup
Clone the repository to your local machine.
Open the project in Visual Studio.
Build and run the project.
How to Use
The project includes buttons on a Windows Forms interface to trigger the various examples. When you click the buttons, you'll see the output of each generic method and class in action, such as swapping values, finding maximum scores, and manipulating collections.
Example Use Cases
Generic Method Example: Swap two int, double, or custom objects with a single generic method.
Generic Class Example: Create a generic class that can handle different types and return a combined string representation of those types.
Finding Maximum Example: Find the student with the highest test score using a generic method and IComparable.
Extension Method Example: Add new methods to existing classes without modifying their source code, like adding an overtime calculation to an Employee class.
Conclusion
This project serves as a practical guide to using generics in C#. It shows how generics can improve code reusability, type safety, and performance. By implementing these techniques, developers can write more flexible and maintainable code that works across various data types without sacrificing efficiency or readability.![Screenshot (163)](https://github.com/user-attachments/assets/1c087ca7-4331-4db7-8e2d-c96c67df9e11)
![Screenshot (162)](https://github.com/user-attachments/assets/a4cc336c-c232-4901-8710-b94d0415ba19)
![Screenshot (161)](https://github.com/user-attachments/assets/e77527f3-b560-4fe5-9280-9a132b8ae9f5)
![Screenshot (160)](https://github.com/user-attachments/assets/43e3f1f5-361f-4f1d-9b7a-5c1f4c39a7e6)
![Screenshot (159)](https://github.com/user-attachments/assets/b18693d9-c8a7-4eab-8c1f-193645ddb2c5)
![Screenshot (158)](https://github.com/user-attachments/assets/b2e8b3d0-f10d-459d-931e-72152ef81dec)
![Screenshot (157)](https://github.com/user-attachments/assets/790d121b-07db-494b-8b72-d53bdc2d7efe)
![Screenshot (156)](https://github.com/user-attachments/assets/ac14d5ad-a598-4fe7-b07e-4be9a08e5b4f)
![Screenshot (155)](https://github.com/user-attachments/assets/7465f1c2-f564-4bc3-8846-789d42e2c13c)
![Screenshot (154)](https://github.com/user-attachments/assets/7b1f0b13-0363-4f39-a063-888c64ccc26e)
