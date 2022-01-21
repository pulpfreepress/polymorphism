# polymorphism
Demonstrates static and dynamic polymorphism in C#. 

Polymorphism, in the programming world, is defined as the ability to treat **different types** of object as if they were the **same type**. 

## Dynamic Polymorphism - Method Overriding
The language features in C# that enable you to implement dynamic ploymorphic behavior include:
- Inheritance (Base Class/Subclass)
	- Define a base class that provides a default behavior implementation
	- Extend the base class to define a derived class that either adds specialized behavior and/or overrides default behavior defined in the base class 
- Inheritance (Abstract Base Class/Subclass)
	- Define an abstract base class which contains one or more abstract methods
	- Extend the abstract base class and provide an implementation for the abstract base class method
- Interfaces
	- Define an interface that provides a specification for behavior and implement the interface


## Static Polymorphism - Ad Hoc - Operator Overloading
- Overload an operator (i.e., '+', '-', etc.) to work on user-defined types. 
	- Examples:
		- int + int
		- int + float
		- int + string
		- string + string

## Static Polymorphism - Parametric - Method Overloading
- Overload methods with different number and types of parameters.
	- Examples:
		- System.Console.WriteLine(object)
		- System.Console.WriteLine(int)
		- System.Console.WriteLine(double)

## Static Polymorphism - Parametric - Generics
- Generic classes and methods enable type specification
	- Examples:
		- List<T>
		- Stack<T>

