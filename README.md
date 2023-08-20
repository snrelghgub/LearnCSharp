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
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/fc9be90f-0f45-439b-adb3-659da4d4d17a)
```csharp
Console.Write("Enter your country name (press Enter for default - Australia): ");
string? countryName = Console.ReadLine();
countryName = String.IsNullOrWhiteSpace(countryName) ? "Australia" : countryName;
Console.Write("Enter your city name (press Enter for default - Sydney): ");
string? cityName = Console.ReadLine();

Console.WriteLine();
cityName = String.IsNullOrWhiteSpace(cityName) ? "Sydney" : cityName;

Console.WriteLine("You live in " + countryName + " & you're located in the city of " + cityName +"!");
```
This code collects user input for the country name & city name using the 'Console.ReadLine()' method. The 'String.IsNullOrWhiteSpace()' method is then used to check if the input is 'null' or consists only of whitespace characters. If the input is 'null' or empty, default values 'Australia' for the country name & 'Sydney' for the city name are assigned. The program then outputs a message to the user displaying the country name, city name, & additional text. The important methods used are 'Console.Write()', 'Console.ReadLine()' & 'String.IsNullOrWhiteSpace()'.
### 7. Work with Arrays in C#
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/fd269555-4bf3-4f09-ba54-ef2d848564d0)
```csharp
Employee[] employees = new Employee[4];

for (int i = 0; i < employees.Length; i++)
{
    DateTime minStartDate = DateTime.Now.AddYears(-10);
    employees[i] = new Employee
    {
        EmployeeId = i,
        EmployeeName = Faker.Name.FullName(NameFormats.Standard),
        EmployeeStartDate = minStartDate.AddDays(new Random().Next((DateTime.Today - minStartDate).Days))
    };
}

for (int i = 0; i < employees.Length; i++)
{
    Console.WriteLine(
        employees[i].EmployeeName + " started work "
        + DateTime.Now.Subtract(employees[i].EmployeeStartDate).Days + " days ago.");
}
```
The provided code generates an array 'employees' of size 4. Using a 'for' loop, it populates each element with a newly created 'Employee' object containing a unique 'EmployeeId', a fake 'EmployeeName', & a random 'EmployeeStartDate' within the past 10 years. In a subsequent loop, the code traverses the 'employees' array, accessing each employee's data using the loop index 'i'. It outputs their name & the calculated number of days they have worked, determined by subtracting their 'EmployeeStartDate' from the current date using 'DateTime.Now.Subtract()'.
### 8. Create Simple Methods
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/98a1a2b7-40b5-43c3-a548-4a85136cd25d)
```csharp
static void SayHelloWorld()
{
    Console.WriteLine("Hello World");
}

SayHelloWorld();
```
The code snippet defines a method called "SayHelloWorld()" in C# with a return type of "void ". This method writes "Hello World" to the console when invoked. It can be called directly without creating an object of a class, making it a convenient way to display the message without unnecessary complexity.
### 9. Develop Advanced Methods
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/f42ce1d9-7d87-4dd9-acb9-6e84b12ce55c)
```csharp
static int fib(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return fib(n - 2) + fib(n - 1);
}

Console.WriteLine(
    ""The 4th number in the Fibonacci sequence is: ""
    + fib(4).ToString()
);
```
This code implements the Fibonacci sequence using a concise recursive approach. The method fib() takes an integer n as input & returns the nth Fibonacci number. It uses the base cases of 0 and 1, returning those values directly. For other values of n, it recursively calls itself with n - 2 and n - 1 as arguments & returns the sum of the two recursive calls. The recursion stops when n reaches 0 or 1. This concise implementation demonstrates the power of recursion in solving problems by breaking them down into smaller, simpler cases.
### 10. Control Flow in C#
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/87ca82db-2350-44b5-8b9d-aa2135d0c64f)
```csharp
List<Person> group = new();

group.Add(new Person { name = Faker.Name.FullName(NameFormats.Standard), age = 11 });
group.Add(new Person { name = Faker.Name.FullName(NameFormats.Standard), age = 15 });
group.Add(new Person { name = Faker.Name.FullName(NameFormats.Standard), age = 24 });
group.Add(new Person { name = Faker.Name.FullName(NameFormats.Standard), age = 67 });

static void printAgeMeaning1(Person person)
{
    if (person.age < 13)
    {
        Console.WriteLine(person.name + " is a child.");
    }
    else if (person.age < 20)
{
    Console.WriteLine(person.name + " is an adolescent.");
}
else if (person.age < 65)
{
    Console.WriteLine(person.name + " is an adult.");
}
else
{
    Console.WriteLine(person.name + "is a Senior.");
}
}

static void printAgeMeaning2(Person person)
{
    switch (person.age)
    {
        case var age when age < 13:
            Console.WriteLine(person.name + " is a child.");
            break;
        case var age when age < 20:
            Console.WriteLine(person.name + " is an adolescent.");
            break;
        case var age when age < 65:
            Console.WriteLine(person.name + " is an adult.");
            break;
        default:
            Console.WriteLine(person.name + "is a Senior.");
            break;
    }
}

Console.WriteLine("Using 'if' statements:");
foreach (Person person in group)
{
    printAgeMeaning1(person);
}

Console.WriteLine();
Console.WriteLine("Using 'switch' statements:");
foreach (Person person in group)
{
    printAgeMeaning2(person);
}
```
This code utilizes two methods, 'printAgeMeaning1' & 'printAgeMeaning2,' to classify a list of people based on their age into categories like child, adolescent, adult, & senior. The code employs 'if' & 'switch' statements to evaluate the age of each person and prints their corresponding classification along with their name. It demonstrates the usage of conditional & switch-based logic to handle different age ranges, providing an organized approach for interpreting & categorizing individuals based on their age within a group.
### 11. Loop with while Statements
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/2d5ab4bf-b61a-4d9d-9b59-dd1db0f8f3dc)
```csharp
List<string> names = new();

using (StreamReader sr = new StreamReader("..\\..\\..\\names-List.txt"))
{
    string? line;
while ((line = sr.ReadLine()) != null)
{
    string[] splitNames = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    names.AddRange(splitNames);
}
};

Console.WriteLine("The names extracted from the text file are:");
foreach (string name in names)
{
    Console.WriteLine(name);
}
```
The provided code uses a 'while' loop with a 'StreamReader' to read from a text file. For each line, it splits the names separated by commas & spaces, adding them to a 'List<string>'. The extracted names are then printed. This practical application demonstrates how to process a file line by line, extract specific data, & build a collection of values using a 'while' loop, which is suitable when dealing with an unknown number of lines in the file.
### 12. Count Characters in Strings
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/eebbb0f5-951e-4b47-bb85-81e16482aa1f)
```csharp
string str = "The quick brown fox jumps over the lazy dogs, creating chaos & confusion.";
char target = 'c';
int count = str.Count((c) => c == target);
Console.WriteLine(str);
Console.WriteLine("The number of '" + target + "' characters found in sentence = " + count);
```
The code reads a string 'str' & counts the occurrences of a target character 'c' within that string using the 'Count()' method. The 'Count()' method applies a lambda expression as a predicate to check if each character in the string is equal to the target character. It iterates through the characters, increments a counter for each match, & stores the count in the 'count' variable. The code then outputs the original string & displays the count of occurrences of the target character. The 'Count()' method simplifies the counting process by handling the iteration & comparison, making it concise & efficient.
### 13. Iterate using for Loops
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/898d7acb-77c0-4863-ab3b-e429e4a61d07)
```csharp
static bool isPrime(int num)
{
    if (num < 2)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
            return false;
    }

    return true;
}

static void printPrimes(int n)
{
    List<int> primesList = new();
    for (int i = 0; i <= n; i++)
    {
        if (isPrime(i))
        {
            primesList.Add(i);
        }
    }
    if (primesList.Count == 0)
    {
        Console.WriteLine("No prime numbers found!");
    }
    else if (primesList.Count == 1)
    {
        Console.WriteLine(primesList[0] + " is a prime number!");
    }
    else if (primesList.Count > 1)
    {
        Console.WriteLine(string.Join(", ", primesList) + " are prime numbers.");
    }
}

int[] numbers = { 1, 2, 3, 4, 50 };
foreach (int n in numbers)
{
    printPrimes(n);
}
```
This code contains two functions, 'isPrime' & 'printPrimes', which utilize for loops for iteration. The 'isPrime' function uses a for loop to iterate from 2 to the square root of a given number in order to check for factors & determine if it is a prime number. The 'printPrimes' function also employs a for loop to iterate from 0 to a given number, calling the 'isPrime' function on each iteration to identify & store prime numbers in a list. The code further utilizes a for-each loop to iterate over an array of numbers, passing each number to the 'printPrimes' function & printing the resulting prime numbers for each input.
### 14. Write Helper Methods
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/b9584ea9-0553-4581-b93e-153f6bec212a)
```csharp
static string Truncate(string str, int maxLength)
{
    return (string.Concat(str.AsSpan(0, maxLength), "..."));
}

string longString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel accumsan diam, non tempus nibh.";
string shortString = Truncate(longString, 10);

Console.WriteLine(shortString);
```
The provided code includes a helper method called 'Truncate', which takes a string 'str' & 'maxLenth' as inputs. Its purpose is to truncate the input string & append "..." to indicate the truncation. This method is practical for .NET-based applications as it exemplifies the use of helper methods that encapsulate common functionality, promoting code reuse & modularity. Helper methods allow developers to enhance maintainability & reusability of their projects, adhering to best practices in software development.
### 15. Add Matrices in C#
![image](https://github.com/snrelghgub/LearnCSharp/assets/48052195/f93629f7-1849-4bc7-8222-2c5982ca6574)
```csharp
int[,] matrix1 =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

int[,] matrix2 =
{
    { 1, 1, 1 },
    { 1, 1, 1 }
};

static int[,] addMatrices(int[,] matrix1, int[,] matrix2)
{
    int rowLength = matrix1.GetLength(0);
    int columnsLength = matrix1.GetLength(1);

    int[,] result = new int[rowLength, columnsLength];

    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            result[i, j] = matrix1[i, j] + matrix2[i, j];
        }
    }
    return result;
}

static void printMatrix(int[,] matrix)
{
    int rowLength = matrix.GetLength(0);
    int columnsLength = matrix.GetLength(1);
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] addition = addMatrices(matrix1, matrix2);
printMatrix(addition);
```
This code demonstrates how to use a 2D array to represent two matrices, 'matrix1' & 'matrix2', which are both of size 3 by 2. The addMatrices function takes these two matrices as input & returns a new 2D array containing the element-wise addition of the two matrices. The function first determines the row & column lengths of the matrices using the 'GetLength' method. It then creates a new 2D array, 'result', with the same dimensions to store the addition results. The function then iterates over each element of the matrices using nested loops with indices 'i' & 'j'. It adds the corresponding elements from 'matrix1' & 'matrix2' & stores the result in the corresponding position of the 'result' array. The 'printMatrix' method is provided to print the resulting matrix to the console in a readable format. It's essential to note that this code assumes that both input matrices have the same dimensions; otherwise, it would result in unexpected behavior or errors.
### 16. Handle Exceptions in C#
### 17. Build Classes and Objects
### 18. Use Constructors in C#
### 19. Define Object Methods
### 20. Getters and Setters in Classes
### 21. Static Class Attributes
### 22. Utilize Static Classes
### 23. Implement Inheritance
