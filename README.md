# MSTestv2 Sandbox

Step by step [MSTestv2](https://www.nuget.org/packages/MSTest.TestFramework/) unit testing guide with code examples.

## Testing with **MSTestv2**  

Performing tests using **MSTestv2** Framework consists of executing **test methods**, which are grouped into **test classes** and then into **Test Projects**. Single test methods can be executed separately or at once
executed in paralell.

## Naming conventions

### Projects and classes

Naming convention for **Test Projects** and **test classes** is to start with the name of tested **Project** or **class** and add `Tests` or `Test` accordingly. E.g.

* `MyProjectTests` - for **Test Project** that tests `MyProject` **Project**

* `MyClassTest.cs` - for **test class** that tests `MyClass.cs` **class**

### Methods

In case of **test methods** the naming convenction consists of three parts:

* tested method name
* under what conditions
* what is expected to happen

```csharp
MyMethod_True_ThrowsException(bool value)
```

Above name indicates that it tests `MyMethod` by passing `true` value as an argument and expects an **Exception** to be thrown.

## Test projects

To create test project use:

```powershell
dotnet new mstest -o <Project_Name>
```

then add the tested project reference to test project

```powershell
dotnet add TEST_PROJECT_NAME/TEST_PROJECT_NAME.csproj reference PROJECT_NAME/PROJECT_NAME.csproj
```

<!-- REFACTOR -->
To declare that a class or method contains tests  
<!-- REFACTOR -->
```csharp
[TestClass]
```
<!-- REFACTOR -->
and
<!-- REFACTOR -->
```csharp
[TestMethod]
```
<!-- REFACTOR -->
attributes are used.

## Running tests

While being in solution root directory use:

```powershell
dotnet test
```

to run all test projects across the solution.

---

## References

* [Microsoft Docs:  Unit testing C# with MSTest and .NET artice](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)

* [Microsoft Developer's Writing tests with MSTest v2 YouTube video](https://www.youtube.com/watch?v=olbC6dPgWqQ)
