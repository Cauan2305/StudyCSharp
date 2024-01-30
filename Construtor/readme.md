# C# Constructors

## Introduction

This repository is dedicated to explaining and demonstrating the use of constructors in C#. Constructors are special methods in a class that are called when a new instance of that class is created. They are used to initialize the object's state and to perform any setup they might need before it is used.

## What are Constructors?

In C#, a constructor is a method that has the same name as the class and does not have a return type. Constructors can be overloaded, meaning a class can have more than one constructor, each with a different set of parameters.

## Basic Example

Here's a simple example of a constructor in a class:

```csharp
public class Person
{
    public string Name;
    public int Age;

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
```

In this example, the `Person` class has a constructor that initializes the `Name` and `Age` properties when a new `Person` object is created.

## Advanced Usage

### Parameterless Constructors

If you don’t provide a constructor for your class, C# creates one by default that instantiates the object and sets member variables to their default values.

## How to Use this Repository

This repository contains various examples of constructors in C#. Explore these examples to understand how constructors work and how they can be used to initialize objects.

## Contact

Cauan Matheus - [cauanmatheustrigo68@gmail.com](mailto:cauanmatheustrigo68@gmail.com)
