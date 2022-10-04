# MSTestv2 Sandbox

Step by step [MSTestv2](https://www.nuget.org/packages/MSTest.TestFramework/) unit testing guide with code examples

## Adding tests

* Create test project

```powershell
dotnet new mstest -o <Project_Name>
```

  > It is a good practice to name the project following to the convention: `<TestedClass>.Tests`

To declare that a class or method contains tests  

```csharp
[TestClass]
```

and

```csharp
[TestMethod]
```

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