# 1. Can you describe just-in-time compilation (JIT) in the context of C#?

## Answer

- Just-In-Time (JIT) Compilation is a technique used by the .NET runtime to provide significant performance improvements by compiling the Intermediate Language (IL) bytecode to native machine code at runtime. Instead of pre-compiling the entire code to native code before executing, the JIT compiler optimizes and compiles only the required methods at runtime, greatly reducing load times and memory usage.

- The main benefits of JIT compilation in the context of C# are:

  - Faster application startup: Because only the necessary parts of the code are compiled, the application starts up more quickly.
  - Better memory usage: Unused IL bytecode is never converted to native code, leading to lower memory usage.
  - Platform-specific optimization: Native code is generated specifically for the runtime platform, allowing better optimization and performance.

- The process followed by the JIT compiler in the context of C# consists of three stages:

  - Loading the IL bytecodes: The CLR loads the required IL bytecode of the method to be executed.
  - Compiling IL bytecodes to native code: The JIT compiler compiles the IL bytecodes to native machine code.
  - Executing the native code: The generated native code is executed.

# 2. What is the difference between a normal class property and a computed class property in C#?

## Answer

- A normal class property is a simple property that holds a value and includes a getter and/or a setter method. These properties can be used to store and retrieve data for an object. The setter is responsible for setting the property value, and the getter is responsible for returning the property value.

- A computed class property, also known as a calculated property, is a property that does not store any data but rather computes its value based on other property values within the class. Computed properties only have a getter method, which returns the calculated result, and do not have a setter method.

- Normal property:

```csharp
public class Person
{
public string FirstName { get; set; }
public string LastName { get; set; }
}
```

- Computed property:

```csharp
public class Person
{
public string FirstName { get; set; }
public string LastName { get; set; }

    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

}
```

In this example, FullName is a computed property that returns the concatenated first name and last name.
