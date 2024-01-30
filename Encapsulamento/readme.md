# C# Encapsulation

## Introduction

This repository aims to explore and demonstrate the concept of Encapsulation in C#. Encapsulation is a fundamental principle of object-oriented programming that involves bundling the data (variables) and methods (functions) that operate on the data into a single unit, known as a class, and restricting access to some of the object's components.

## What is Encapsulation?

Encapsulation is the technique of making the fields in a class private and providing public methods to access and modify the values stored in the fields. This approach hides the internal state of the object from the outside world and only allows interaction with it in an allowed manner.

## Basic Example

Here's a simple example of encapsulation in a class:

```csharp
public class Person
{
    private string name; // Private field

    // Public property to access and update the name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
```

In this example, the `name` field is private and can only be accessed or modified through the public `Name` property.

## Advantages of Encapsulation

1. **Control**: Restricts unauthorized access and modification of data.
2. **Flexibility and Maintenance**: Allows the implementation to be changed without affecting other parts of the code.
3. **Increased Security**: Provides a way to protect data from accidental corruption.

## Implementing Encapsulation

Encapsulation can be implemented using:

- **Access Modifiers**: Like private, protected, public, etc., to control access to the class members.
- **Properties**: To provide a public way of getting and setting values, while hiding implementation or verification code.

## Use Cases

Encapsulation is used when:

- You want to protect the internal state of an object from direct modification.
- You need to provide controlled access to the members of a class.

## How to Use this Repository

This repository contains various examples and best practices for implementing encapsulation in C#. It demonstrates how to properly encapsulate data and methods within a class to ensure robust and maintainable code.

## Contact

Cauan Matheus - [cauanmatheustrigo68@gmail.com](mailto:cauanmatheustrigo68@gmail.com)
