# C# Auto Properties

## Introduction

This repository aims to explain and demonstrate the use of Auto Properties in C#. Auto Properties are a simplified way of declaring properties in a C# class that allow us to concisely define properties without the explicit need for a backing field.

## What are Auto Properties?

Introduced in C# 3.0, Auto Properties allow developers to declare properties in a class without writing additional code for the `get` and `set` methods. They are particularly useful for simplifying code where a property simply encapsulates a private field.

## Basic Example

A simple example of an Auto Property:

```csharp
public class Person
{
    public string Name { get; set; }
}
```

In this example, `Name` is an Auto Property. C# automatically creates a private backing field for it, and the `get` and `set` methods are implemented automatically.

## Advanced Usage

### Read-Only Properties

You can also create read-only Auto Properties, which have only a `get` method:

```csharp
public class Person
{
    public string Name { get; }
}
```

### Property Initializers

From C# 6.0 onwards, you can initialize Auto Properties directly in their declaration:

```csharp
public class Person
{
    public string Name { get; set; } = "Default Name";
}
```

## Contact

Cauan Matheus - [cauanmatheustrigo68@gmail.com](mailto:cauanmatheustrigo68@gmail.com)
