# C# Properties

## Introduction

This repository is dedicated to explaining and demonstrating the use of Properties in C#. Properties in C# are members that provide a flexible mechanism to read, write, or compute the values of private fields. They can be used as if they were public data members, but they actually include special methods called accessors.

## What are Properties?

Properties in C# are a way of encapsulating a private field behind a public interface. They use accessors, `get` and `set`, to define how the value can be read and written. Properties can be read-only (with only a `get` accessor), write-only (with only a `set` accessor), or read-write (with both).

## Basic Example

Here's a simple example of a property in a class:

```csharp
public class Person
{
    private string name;

    // Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
```

In this example, `Name` is a property of the `Person` class. It encapsulates the private field `name`.


### Property with Logic in Accessors

You can include logic within your property accessors:

```csharp
public class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
        }
    }
}
```

## Advantages of Using Properties

1. **Encapsulation**: Safely expose private fields using properties.
2. **Validation**: Validate data before assigning it to the underlying field.
3. **Ease of Use**: Simplify the interface of your class.

## How to Use this Repository

This repository contains various examples showing different ways of using Properties in C#. Explore these examples to understand how Properties can be used to make your code more robust and maintainable.

## Contact

Cauan Matheus - [cauanmatheustrigo68@gmail.com](mailto:cauanmatheustrigo68@gmail.com)
