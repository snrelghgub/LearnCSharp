# Learn C#
## Table of Contents
1. [Draw Shapes with C#](#1-draw-shapes-with-c)
2. [Master Variables in C#](#2-master-variables-in-c)
3. [Choose Data Types in C#](#3-choose-data-types-in-c)
4. [Manipulate Strings in C#](#4-manipulate-strings-in-c)
5. [Operate with Numbers in C#](#5-operate-with-numbers-in-c)
6. [Get User Input in C#](#6-get-user-input-in-c)
7. [Work with Arrays in C#](#7-work-with-arrays-in-c)
8. [Create Simple Methods](#8-create-simple-methods)
9. [Develop Advanced Methods](#9-develop-advanced-methods)
10. [Control Flow in C#](#10-control-flow-in-c)
11. [Loop with while Statements](#11-loop-with-while-statements)
12. [Count Characters in Strings](#12-count-characters-in-strings)
13. [Iterate using for Loops](#13-iterate-using-for-loops)
14. [Write Helper Methods](#14-write-helper-methods)
15. [Add Matrices in C#](#15-add-matrices-in-c)
16. [Handle Exceptions in C#](#16-handle-exceptions-in-c)
17. [Build Classes and Objects](#17-build-classes-and-objects)
18. [Use Constructors in C#](#18-use-constructors-in-c)
19. [Define Object Methods](#19-define-object-methods)
20. [Getters and Setters in Classes](#20-getters-and-setters-in-classes)
21. [Static Class Attributes](#21-static-class-attributes)
22. [Utilize Static Classes](#22-utilize-static-classes)
23. [Implement Inheritance](#23-implement-inheritance)
---
### 1. Draw Shapes with C#
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/1ee82ed6-6cc6-440c-8bec-5781fdca4b54)
```csharp
int width = 10;
int height = 5;

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
```
The code uses two loops to draw a rectangle made of asterisks ('*'). The 'width' & 'height' variables determine the dimensions of the rectangle. The outer loop controls the number of rows, & the inner loop controls the number of asterisks printed per row. The code repeatedly prints asterisks in each row, forming a rectangular shape.
### 2. Master Variables in C#
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/b534d219-7af5-4f46-a712-060dfe1a101d)
```csharp
while (true)
{
    DateTime currentTime = DateTime.Now;
    string date = currentTime.ToString("dd/MM/yyyy");
    string time = currentTime.ToString("hh:mm:ss tt");

    Console.WriteLine(date + " - " + time);

    Thread.Sleep(1000);
    Console.Clear();
}
```
This code uses the built-in 'DateTime' data type in C# to extract the current date and time. The variable 'currentTime' is a new instance of the 'DateTime' data type, while 'date' and 'time' are string variables that will hold the formatted date and time values, respectively. The 'ToString()' method is used to extract the month data from 'currentTime' using "MM" and the minutes data using "mm" etc. The Sleep method sets a pause to the while loop for one second, allowing the clock to update correctly. The 'Console.Clear()' method is used to clear the console screen to update the clock every second. The final result is a clock that displays both the 'date' and 'time' accurately. The 'Sleep()' method is part of the System.Threading namespace in C#. The 'WriteLine' method comes from the Console class in C#, which is part of the .Net Framework class library in the System namespace used to print the date & time string variables to the console. Other examples of classes in the System namespace are 'DateTime' and 'ConsoleColor'.
### 3. Choose Data Types in C#
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/bf4df29f-7c54-4612-bdfd-90c014370416)
```csharp
float num1 = 1.1234567890123456789f;
double num2 = 1.1234567890123456789;
decimal num3 = 1.1234567890123456789m;

Console.WriteLine("num1 (float):" + num1);
Console.WriteLine("num2 (double):" + num2);
Console.WriteLine("num3 (decimal):" + num3);
```
The code demonstrates the differences in precision among 'float', 'double', & 'decimal' data types. 'Float' offers the lowest precision with approximately 7 significant digits, while 'double' provides higher precision with around 15-16 significant digits. Decimal offers the highest precision with approximately 28-29 significant digits. Use 'decimal' for situations requiring utmost precision, like financial calculations, to avoid rounding errors. Use 'float' when storage efficiency is crucial & the extra precision is not necessary, such as in large datasets where reducing memory footprint improves performance.
### 4. Manipulate Strings in C#
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/4d1ab5be-8380-4b5e-b428-7c56c6b80d0e)
```csharp
string name1 = Faker.Name.FullName(NameFormats.Standard);
string address1 = Faker.Address.StreetAddress() + ", " + Faker.Address.City() + ", " + Faker.Address.UsState() + ", " + Faker.Address.ZipCode();
string person1 = String.Concat("Name: ", name1, "\nAddress: ", address1);

string name2 = Faker.Name.FullName(NameFormats.Standard);
string landlineNumber2 = Faker.Phone.Number().Replace(".", "-").Split("x")[0].Trim();
string person2 = String.Concat("Name: ", name2, "\nLandline number: ", landlineNumber2);

string name3 = Faker.Name.FullName(NameFormats.Standard);
string address3 = Faker.Address.StreetAddress() + ", " + Faker.Address.City() + ", " + Faker.Address.UsState() + ", " + Faker.Address.ZipCode();
string landlineNumber3 = Faker.Phone.Number().Replace(".", "-").Split("x")[0].Trim();
string person3 = String.Concat("Name: ", name3, "\nAddress: ", address3, "\nLandline number: ", landlineNumber3);

string[] people = new string[3];
people[0] = person1;
people[1] = person2;
people[2] = person3;

foreach (string person in people)
{
    Console.WriteLine(person);
    Console.WriteLine($"{(person.Contains("Name") ? 1 : 0)} name was found.");
    Console.WriteLine($"{(person.Contains("Address") ? 1 : 0)} address was found.");
    Console.WriteLine($"{(person.Contains("Landline number") ? 1 : 0)} landline number was found.");
    Console.WriteLine();
}
```
This code utilizes the Faker.Net library to generate three fake individuals' information, including their names, addresses, & landline numbers. The generated details are stored in separate string variables. These variables are then inserted into a string array 'people', allowing the code to loop through each person's information & report the occurrence of their name, address, & landline number. The Contains() method is employed to check for the presence of specific details within each person's string, enabling the code to generate a report for each individual. This code provides a practical example of working with strings in C#, showcasing concatenation, string arrays, and the Contains() method for efficient string handling & analysis.
### 5. Operate with Numbers in C#
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/4acac89f-9768-4b7b-adc1-19387611141b)
```csharp
double radius = 5;
double angle = 45;
double radians = angle * (Math.PI / 180);
double xCoordinate = radius * Math.Cos(radians);
double yCoordinate = radius * Math.Sin(radians);
Console.WriteLine(String.Concat(
    "The (x, y) coordinates of a point on a circle with radius ", radius,
    "at an angle of ", angle, "\u00B0 is ",
    "(", Math.Round(xCoordinate, 2), ",", Math.Round(yCoordinate, 2), ")"));
}
```
This code calculates the (x, y) coordinates of a point on a circle with a given 'radius' & 'angle'. By utilizing the Math library's methods such as 'Cos()', 'Sin()', and constants like 'PI', the code converts the 'angle' from degrees to 'radians' & then calculates the x & y coordinates using trigonometric functions. The result is displayed in a formatted message using 'Console.WriteLine', with the coordinates rounded to two decimal places for clarity. These Math library functions & constants make it easier to perform calculations involving angles, circles & trigonometry.
### 6. Get User Input in C#
### 7. Work with Arrays in C#
### 8. Create Simple Methods
### 9. Develop Advanced Methods
### 10. Control Flow in C#
### 11. Loop with while Statements
### 12. Count Characters in Strings
### 13. Iterate using for Loops
### 14. Write Helper Methods
### 15. Add Matrices in C#
### 16. Handle Exceptions in C#
### 17. Build Classes and Objects
### 18. Use Constructors in C#
### 19. Define Object Methods
### 20. Getters and Setters in Classes
### 21. Static Class Attributes
### 22. Utilize Static Classes
### 23. Implement Inheritance
