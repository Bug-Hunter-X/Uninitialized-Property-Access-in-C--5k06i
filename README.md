# C# Uninitialized Property Access Bug

This repository demonstrates a common error in C#: accessing a class property before it has been assigned a value.

## The Bug
The `Bug.cs` file contains a class with a property that is accessed within a method before it is initialized. This can lead to unpredictable behavior, particularly if the property is a reference type (e.g., a string or an object).  In the case of value types (like ints), the property may have a default value, which may still be unexpected.

## The Solution
The `BugSolution.cs` file shows how to fix this issue by ensuring that the property is assigned a value before it's accessed. This can be done either by assigning a default value in the property declaration or by initializing it explicitly before usage. 

## How to Run
1. Clone the repository.
2. Open the solution in Visual Studio or another compatible IDE.
3. Build and run the code.