using Faker;
using LearnCSharp.Models;

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Learn C#");
Console.ResetColor();





Console.WriteLine();
Console.WriteLine("1. Draw Shapes with C#");
Console.WriteLine();

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

string codeExample1 = @"
int width = 10; 
int height = 5;

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(""*"");
    }
    Console.WriteLine();
}";

Console.WriteLine(codeExample1);

string codeExplanation1 = @"
The code uses two loops to draw a rectangle made of asterisks ('*'). The 'width' & 'height' 
variables determine the dimensions of the rectangle. The outer loop controls the number of 
rows, & the inner loop controls the number of asterisks printed per row. 
The code repeatedly prints asterisks in each row, forming a rectangular shape.
";

Console.WriteLine(codeExplanation1);






Console.WriteLine();
Console.WriteLine("2. Master Variables in C#");
Console.WriteLine();

//while (true)
//{
DateTime currentTime = DateTime.Now;
    string date = currentTime.ToString("dd/MM/yyyy");
    string time = currentTime.ToString("hh:mm:ss tt");

    Console.WriteLine(date + " - " + time);

//Thread.Sleep(1000);
//Console.Clear();
//Console.ReadLine();
//}

string codeExample2 = @"
while (true)
{
    DateTime currentTime = DateTime.Now;
    string date = currentTime.ToString(""dd/MM/yyyy"");
    string time = currentTime.ToString(""hh:mm:ss tt"");

    Console.WriteLine(date + "" - "" + time);

    Thread.Sleep(1000);
    Console.Clear();
}";

Console.WriteLine(codeExample2);

string codeExplanation2 = @"
This code uses the built-in 'DateTime' data type in C# to extract 
the current date and time. The variable 'currentTime' is a new 
instance of the 'DateTime' data type, while 'date' and 'time' are 
string variables that will hold the formatted date and time values, 
respectively. The 'ToString()' method is used to extract the month data from 
'currentTime' using ""MM"" and the minutes data using ""mm"" etc. 
The Sleep method sets a pause to the while loop for one second, 
allowing the clock to update correctly. The 'Console.Clear()' method 
is used to clear the console screen to update the clock every second. 
The final result is a clock that displays both the 'date' and 'time' accurately. 
The 'Sleep()' method is part of the System.Threading namespace in C#. The 'WriteLine' 
method comes from the Console class in C#, which is part of the .Net Framework 
class library in the System namespace used to print the date & time string 
variables to the console. Other examples of classes in the System namespace 
are 'DateTime' and 'ConsoleColor'.";

Console.WriteLine(codeExplanation2);






Console.WriteLine();
Console.WriteLine("3. Choose Data Types in C#");
Console.WriteLine();

float num1 = 1.1234567890123456789f;
double num2 = 1.1234567890123456789;
decimal num3 = 1.1234567890123456789m;

Console.WriteLine("num1 (float):" + num1);
Console.WriteLine("num2 (double):" + num2);
Console.WriteLine("num3 (decimal):" + num3);

string codeExample3 = @"
float num1 = 1.1234567890123456789f;
double num2 = 1.1234567890123456789;
decimal num3 = 1.1234567890123456789m;

Console.WriteLine(""num1 (float):"" + num1);
Console.WriteLine(""num2 (double):"" + num2);
Console.WriteLine(""num3 (decimal):"" + num3);
";

Console.WriteLine(codeExample3);

string codeExplanation3 = @"
The code demonstrates the differences in precision among 'float', 'double', 
& 'decimal' data types. 'Float' offers the lowest precision with approximately 
7 significant digits, while 'double' provides higher precision with around 
15-16 significant digits. Decimal offers the highest precision with 
approximately 28-29 significant digits. Use 'decimal' for situations requiring 
utmost precision, like financial calculations, to avoid rounding errors. 
Use 'float' when storage efficiency is crucial & the extra precision is 
not necessary, such as in large datasets where reducing memory footprint 
improves performance.
";

Console.Write(codeExplanation3);






Console.WriteLine();
Console.WriteLine("4.Manipulate Strings in C#");
Console.WriteLine();

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

string codeExample4 = @"
string name1 = Faker.Name.FullName(NameFormats.Standard);
string address1 = Faker.Address.StreetAddress() + "", "" + Faker.Address.City() + "", "" + Faker.Address.UsState() + "", "" + Faker.Address.ZipCode();
string person1 = String.Concat(""Name: "", name1, ""\nAddress: "", address1);

string name2 = Faker.Name.FullName(NameFormats.Standard);
string landlineNumber2 = Faker.Phone.Number().Replace(""."", ""-"").Split(""x"")[0].Trim();
string person2 = String.Concat(""Name: "", name2, ""\nLandline number: "", landlineNumber2);

string name3 = Faker.Name.FullName(NameFormats.Standard);
string address3 = Faker.Address.StreetAddress() + "", "" + Faker.Address.City() + "", "" + Faker.Address.UsState() + "", "" + Faker.Address.ZipCode();
string landlineNumber3 = Faker.Phone.Number().Replace(""."", ""-"").Split(""x"")[0].Trim();
string person3 = String.Concat(""Name: "", name3, ""\nAddress: "", address3, ""\nLandline number: "", landlineNumber3);

string[] people = new string[3];
people[0] = person1;
people[1] = person2;
people[2] = person3;

foreach (string person in people)
{
    Console.WriteLine(person);
    Console.WriteLine($""{(person.Contains(""Name"") ? 1 : 0)} name was found."");
    Console.WriteLine($""{(person.Contains(""Address"") ? 1 : 0)} address was found."");
    Console.WriteLine($""{(person.Contains(""Landline number"") ? 1 : 0)} landline number was found."");
    Console.WriteLine();
}";

Console.WriteLine(codeExample4);

string codeExplanation4 = @"
This code utilizes the Faker.Net library to generate three fake individuals' 
information, including their names, addresses, & landline numbers. The 
generated details are stored in separate string variables. These variables 
are then inserted into a string array 'people', allowing the code to loop 
through each person's information & report the occurrence of their name, 
address, & landline number. The Contains() method is employed to check 
for the presence of specific details within each person's string, enabling 
the code to generate a report for each individual. This code provides a 
practical example of working with strings in C#, showcasing concatenation, 
string arrays, and the Contains() method for efficient string handling & 
analysis.
";

Console.WriteLine(codeExplanation4);






Console.WriteLine();
Console.WriteLine("5. Operate with Numbers in C#");
Console.WriteLine();

double radius = 5;
double angle = 45;
double radians = angle * (Math.PI / 180);
double xCoordinate = radius * Math.Cos(radians);
double yCoordinate = radius * Math.Sin(radians);
Console.WriteLine(String.Concat(
    "The (x,y) coordinates of a point on a circle with radius ", radius,
    " at an angle of ", angle, "\u00B0 is ",
    "(", Math.Round(xCoordinate, 2), ",", Math.Round(yCoordinate, 2), ")"));

string codeExample5 = @"
double radius = 5;
double angle = 45;
double radians = angle * (Math.PI / 180);
double xCoordinate = radius * Math.Cos(radians);
double yCoordinate = radius * Math.Sin(radians);
Console.WriteLine(String.Concat(
    ""The (x, y) coordinates of a point on a circle with radius "", radius,
    ""at an angle of "", angle, ""\u00B0 is "",
    ""("", Math.Round(xCoordinate, 2), "","", Math.Round(yCoordinate, 2), "")""));
}";

Console.WriteLine(codeExample5);

string codeExplanation5 = @"
This code calculates the (x, y) coordinates of a point on a circle with 
a given 'radius' & 'angle'. By utilizing the Math library's methods 
such as 'Cos()', 'Sin()', and constants like 'PI', the code converts 
the 'angle' from degrees to 'radians' & then calculates the x & y 
coordinates using trigonometric functions. The result is displayed 
in a formatted message using 'Console.WriteLine', with the 
coordinates rounded to two decimal places for clarity. These Math 
library functions & constants make it easier to perform calculations 
involving angles, circles & trigonometry.
";

Console.WriteLine(codeExplanation5);






Console.WriteLine();
Console.WriteLine("6. Get User Input in C#");
Console.WriteLine();

Console.Write("Enter your country name (press Enter for default - Australia): ");
string? countryName = Console.ReadLine();
countryName = String.IsNullOrWhiteSpace(countryName) ? "Australia" : countryName;
Console.Write("Enter your city name (press Enter for default - Sydney): ");
string? cityName = Console.ReadLine();

Console.WriteLine();
cityName = String.IsNullOrWhiteSpace(cityName) ? "Sydney" : cityName;

Console.WriteLine("You live in " + countryName + " & you're located in the city of " + cityName +"!");

string codeExample6 = @"
Console.Write(""Enter your country name (press Enter for default - Australia): "");
string? countryName = Console.ReadLine();
countryName = String.IsNullOrWhiteSpace(countryName) ? ""Australia"" : countryName;
Console.Write(""Enter your city name (press Enter for default - Sydney): "");
string? cityName = Console.ReadLine();

Console.WriteLine();
cityName = String.IsNullOrWhiteSpace(cityName) ? ""Sydney"" : cityName;

Console.WriteLine(""You live in "" + countryName + "" & you're located in the city of "" + cityName + ""!""); 
";

Console.WriteLine(codeExample6);

string codeExplanation6 = @"
This code collects user input for the country name & city name 
using the 'Console.ReadLine()' method. The 'String.IsNullOrWhiteSpace()'
method is then used to check if the input is 'null' or consists only of 
whitespace characters. If the input is 'null' or empty, default values 
'Australia' for the country name & 'Sydney' for the city name are assigned. 
The program then outputs a message to the user displaying the country name, 
city name, & additional text. The important methods used are 'Console.Write()', 
'Console.ReadLine()' & 'String.IsNullOrWhiteSpace()'.
";

Console.WriteLine(codeExplanation6);






Console.WriteLine();
Console.WriteLine("7. Work with Arrays in C#");
Console.WriteLine();

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

string codeExample7 = @"
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
        employees[i].EmployeeName + "" started work ""
        + DateTime.Now.Subtract(employees[i].EmployeeStartDate).Days + "" days ago."");
}
";

Console.WriteLine(codeExample7);

string codeExplanation7 = @"
The provided code generates an array 'employees' of size 4. 
Using a 'for' loop, it populates each element with a newly 
created 'Employee' object containing a unique 'EmployeeId', 
a fake 'EmployeeName', & a random 'EmployeeStartDate' within 
the past 10 years. In a subsequent loop, the code traverses 
the 'employees' array, accessing each employee's data using 
the loop index 'i'. It outputs their name & the calculated 
number of days they have worked, determined by subtracting 
their 'EmployeeStartDate' from the current date using 
'DateTime.Now.Subtract()'.
";

Console.WriteLine(codeExplanation7);






Console.WriteLine();
Console.WriteLine("8. Create Simple Methods");
Console.WriteLine();

static void SayHelloWorld()
{
    Console.WriteLine("Hello World");
}

SayHelloWorld();

string codeExample8 = @"
static void SayHelloWorld()
{
    Console.WriteLine(""Hello World"");
}

SayHelloWorld();
";

Console.WriteLine(codeExample8);

string codeExplanation8 = @"
The code snippet defines a method called ""SayHelloWorld()"" 
in C# with a return type of ""void "". This method writes 
""Hello World"" to the console when invoked. It can be called 
directly without creating an object of a class, making it a 
convenient way to display the message without unnecessary complexity.
";

Console.WriteLine(codeExplanation8);






Console.WriteLine();
Console.WriteLine("9. Develop Advanced Methods");
Console.WriteLine();

static int fib(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return fib(n - 2) + fib(n - 1);
}

Console.WriteLine(
    "The 4th number in the Fibonacci sequence is: "
    + fib(4).ToString()
);

string codeExample9 = @"
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
";

Console.Write(codeExample9);

string codeExplanation9 = @"
This code implements the Fibonacci sequence using a 
concise recursive approach. The method fib() takes 
an integer n as input & returns the nth Fibonacci number. 
It uses the base cases of 0 and 1, returning those 
values directly. For other values of n, it recursively 
calls itself with n - 2 and n - 1 as arguments & returns
the sum of the two recursive calls. The recursion stops 
when n reaches 0 or 1. This concise implementation 
demonstrates the power of recursion in solving problems 
by breaking them down into smaller, simpler cases.
";

Console.WriteLine(codeExplanation9);






Console.WriteLine();
Console.WriteLine("10. Control Flow in C#");
Console.WriteLine();

List<Person> group = new();

group.Add(new Person { Name = Faker.Name.FullName(NameFormats.Standard), Age = 11 });
group.Add(new Person { Name = Faker.Name.FullName(NameFormats.Standard), Age = 15 });
group.Add(new Person { Name = Faker.Name.FullName(NameFormats.Standard), Age = 24 });
group.Add(new Person { Name = Faker.Name.FullName(NameFormats.Standard), Age = 67 });

static void printAgeMeaning1(Person person)
{
    if (person.Age < 13)
    {
        Console.WriteLine(person.Name + " is a child.");
    }
    else if (person.Age < 20)
    {
        Console.WriteLine(person.Name + " is an adolescent.");
    }
    else if (person.Age < 65)
    {
        Console.WriteLine(person.Name + " is an adult.");
    }
    else
    {
        Console.WriteLine(person.Name + "is a Senior.");
    }
}

static void printAgeMeaning2(Person person)
{
    switch (person.Age)
    {
        case var age when age < 13:
            Console.WriteLine(person.Name + " is a child.");
            break;
        case var age when age < 20:
            Console.WriteLine(person.Name + " is an adolescent.");
            break;
        case var age when age < 65:
            Console.WriteLine(person.Name + " is an adult.");
            break;
        default:
            Console.WriteLine(person.Name + "is a Senior.");
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

string codeExample10 = @"
List<Person> group = new();

group.Add(new Person { name = Faker.Name.FullName(NameFormats.Standard), age = 11 });
group.Add(new Person { name = Faker.Name.FullName(NameFormats.Standard), age = 15 });
group.Add(new Person { name = Faker.Name.FullName(NameFormats.Standard), age = 24 });
group.Add(new Person { name = Faker.Name.FullName(NameFormats.Standard), age = 67 });

static void printAgeMeaning1(Person person)
{
    if (person.age < 13)
    {
        Console.WriteLine(person.name + "" is a child."");
    }
    else if (person.age < 20)
{
    Console.WriteLine(person.name + "" is an adolescent."");
}
else if (person.age < 65)
{
    Console.WriteLine(person.name + "" is an adult."");
}
else
{
    Console.WriteLine(person.name + ""is a Senior."");
}
}

static void printAgeMeaning2(Person person)
{
    switch (person.age)
    {
        case var age when age < 13:
            Console.WriteLine(person.name + "" is a child."");
            break;
        case var age when age < 20:
            Console.WriteLine(person.name + "" is an adolescent."");
            break;
        case var age when age < 65:
            Console.WriteLine(person.name + "" is an adult."");
            break;
        default:
            Console.WriteLine(person.name + ""is a Senior."");
            break;
    }
}

Console.WriteLine(""Using 'if' statements:"");
foreach (Person person in group)
{
    printAgeMeaning1(person);
}

Console.WriteLine();
Console.WriteLine(""Using 'switch' statements:"");
foreach (Person person in group)
{
    printAgeMeaning2(person);
}
";

Console.WriteLine(codeExample10);

string codeExplanation = @"
This code utilizes two methods, 'printAgeMeaning1' &
'printAgeMeaning2,' to classify a list of people based
on their age into categories like child, adolescent, 
adult, & senior. The code employs 'if' & 'switch' statements 
to evaluate the age of each person and prints their 
corresponding classification along with their name. 
It demonstrates the usage of conditional & switch-based 
logic to handle different age ranges, providing an 
organized approach for interpreting & categorizing 
individuals based on their age within a group.
";

Console.WriteLine(codeExplanation);






Console.WriteLine();
Console.WriteLine("11. Loop with while Statements");
Console.WriteLine();

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

string codeExample11 = @"
List<string> names = new();

using (StreamReader sr = new StreamReader(""..\\..\\..\\names-List.txt""))
{
    string? line;
while ((line = sr.ReadLine()) != null)
{
    string[] splitNames = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    names.AddRange(splitNames);
}
};

Console.WriteLine(""The names extracted from the text file are:"");
foreach (string name in names)
{
    Console.WriteLine(name);
}
";

Console.WriteLine(codeExample11);

string codeExplanation11 = @"
The provided code uses a 'while' loop with a 
'StreamReader' to read from a text file. For 
each line, it splits the names separated by 
commas & spaces, adding them to a 'List<string>'. 
The extracted names are then printed. This 
practical application demonstrates how to 
process a file line by line, extract specific 
data, & build a collection of values using a 
'while' loop, which is suitable when dealing 
with an unknown number of lines in the file.
";

Console.WriteLine(codeExplanation11);






Console.WriteLine();
Console.WriteLine("12.Count Characters in Strings");
Console.WriteLine();

string str = "The quick brown fox jumps over the lazy dogs, creating chaos & confusion.";
char target = 'c';
int count = str.Count((c) => c == target);
Console.WriteLine(str);
Console.WriteLine("The number of '" + target + "' characters found in sentence = " + count);

string codeExample12 = @"
string str = ""The quick brown fox jumps over the lazy dogs, creating chaos & confusion."";
char target = 'c';
int count = str.Count((c) => c == target);
Console.WriteLine(str);
Console.WriteLine(""The number of '"" + target + ""' characters found in sentence = "" + count);
";

Console.WriteLine(codeExample12);

string codeExplanation12 = @"
The code reads a string 'str' & counts the 
occurrences of a target character 'c' within 
that string using the 'Count()' method. The 'Count()' 
method applies a lambda expression as a predicate to 
check if each character in the string is equal to the 
target character. It iterates through the characters, 
increments a counter for each match, & stores the count 
in the 'count' variable. The code then outputs the 
original string & displays the count of occurrences 
of the target character. The 'Count()' method simplifies 
the counting process by handling the iteration & comparison, 
making it concise & efficient.
";

Console.WriteLine(codeExplanation12);






Console.WriteLine();
Console.WriteLine("13. Iterate using for Loops");
Console.WriteLine();

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

string codeExample13 = @"
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
        Console.WriteLine(""No prime numbers found!"");
    }
    else if (primesList.Count == 1)
    {
        Console.WriteLine(primesList[0] + "" is a prime number!"");
    }
    else if (primesList.Count > 1)
    {
        Console.WriteLine(string.Join("", "", primesList) + "" are prime numbers."");
    }
}

int[] numbers = { 1, 2, 3, 4, 50 };
foreach (int n in numbers)
{
    printPrimes(n);
}
";

Console.WriteLine(codeExample13);

string codeExplanation13 = @"
This code contains two functions, 'isPrime' & 'printPrimes', 
which utilize for loops for iteration. The 'isPrime' function 
uses a for loop to iterate from 2 to the square root of a 
given number in order to check for factors & determine if 
it is a prime number. The 'printPrimes' function also employs 
a for loop to iterate from 0 to a given number, calling the 
'isPrime' function on each iteration to identify & store 
prime numbers in a list. The code further utilizes a for-each 
loop to iterate over an array of numbers, passing each number 
to the 'printPrimes' function & printing the resulting prime 
numbers for each input.
";

Console.WriteLine(codeExplanation13);






Console.WriteLine();
Console.WriteLine("14. Write Helper Methods");
Console.WriteLine();

static string Truncate(string str, int maxLength)
{
    return (string.Concat(str.AsSpan(0, maxLength), " ..."));
}

string longString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel accumsan diam, non tempus nibh.";
string shortString = Truncate(longString, 10);

Console.WriteLine(shortString);

string codeExample14 = @"
static string Truncate(string str, int maxLength)
{
    return (string.Concat(str.AsSpan(0, maxLength), ""...""));
}

string longString = ""Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vel accumsan diam, non tempus nibh."";
string shortString = Truncate(longString, 10);

Console.WriteLine(shortString);
";
string codeExplanation14 = @"
The provided code includes a helper method called 'Truncate', 
which takes a string 'str' & 'maxLenth' as inputs. Its purpose 
is to truncate the input string & append ""..."" to indicate the 
truncation. This method is practical for .NET-based applications 
as it exemplifies the use of helper methods that encapsulate common 
functionality, promoting code reuse & modularity. Helper methods 
allow developers to enhance maintainability & reusability of their 
projects, adhering to best practices in software development.
";

Console.WriteLine(codeExample14);
Console.WriteLine(codeExplanation14);






Console.WriteLine();
Console.WriteLine("15. Add Matrices in C#");
Console.WriteLine();

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


string codeExample15 = @"
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
            Console.Write(matrix[i, j] + "" "");
        }
        Console.WriteLine();
    }
}

int[,] addition = addMatrices(matrix1, matrix2);
printMatrix(addition);
";

string codeExplanation15 = @"
This code demonstrates how to use a 2D array to represent two 
matrices, 'matrix1' & 'matrix2', which are both of size 3 by 2. The 
'addMatrices' function takes these two matrices as input & returns 
a new 2D array containing the element-wise addition of the two 
matrices. The function first determines the row & column lengths 
of the matrices using the GetLength method. It then creates a 
new 2D array, 'result', with the same dimensions to store the 
addition results. The function then iterates over each element 
of the matrices using nested loops with indices 'i' & 'j'. It adds 
the corresponding elements from 'matrix1' & 'matrix2' & stores 
the result in the corresponding position of the 'result' array. 
The 'printMatrix' method is provided to print the resulting matrix 
to the console in a readable format. It's essential to note that 
this code assumes that both input matrices have the same dimensions; 
otherwise, it would result in unexpected behavior or errors. 
";

Console.WriteLine(codeExample15);
Console.WriteLine(codeExplanation15);






Console.WriteLine();
Console.WriteLine("16. Handle Exceptions in C#");
Console.WriteLine();

try
{
    using (HttpClient httpClient = new HttpClient())
    {
        string invalidUrl = "https://example.com/nonexistent-page";
        HttpResponseMessage response = await httpClient.GetAsync(invalidUrl);

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Failed to fetch data. Status code: {response.StatusCode}");
        }
        else
        {
            Console.WriteLine("Request was successful!");
        }
    }
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"Caught an HttpRequestException: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Caught an unexpected exception: {ex.Message}");
}

string codeExample16 = @"
try
{
    using (HttpClient httpClient = new HttpClient())
    {
        string invalidUrl = ""https://example.com/nonexistent-page"";
        HttpResponseMessage response = await httpClient.GetAsync(invalidUrl);

if (!response.IsSuccessStatusCode)
{
    throw new HttpRequestException($""Failed to fetch data. Status code: {response.StatusCode}"");
}
else
{
    Console.WriteLine(""Request was successful!"");
}
    }
}
catch (HttpRequestException ex)
{
    Console.WriteLine($""Caught an HttpRequestException: {ex.Message}"");
}
catch (Exception ex)
{
    Console.WriteLine($""Caught an unexpected exception: {ex.Message}"");
}
";

string codeExplanation16 = @"
This C# code exemplifies the concept of exception handling, 
essential for managing errors during program execution. The 
'try' block attempts to make an HTTP GET request to a non-existent 
URL. If the request fails (status code indicating failure), a 
custom 'HttpRequestException' is thrown with a specific error 
message. The 'catch' blocks are designed to catch different types 
of exceptions. The first 'catch' block handles the custom 
'HttpRequestException', displaying the error message to the user. 
The second 'catch' block catches any other unexpected exceptions. 
This code structure allows developers to gracefully handle errors 
during web requests, ensuring informative feedback 
about any issues that occurred during the process. 
";

Console.WriteLine(codeExample16);
Console.WriteLine(codeExplanation16);






Console.WriteLine();
Console.WriteLine("17. Build Classes and Objects");
Console.WriteLine();

Book book1 = new Book
{
    name = "Clean Code: A Handbook of Agile Software Craftsmanship",
    author = new string[] { "Robert C. Martin (Uncle Bob)" },
    publishingDate = new DateOnly(2008, 8, 11),
    ISBN10 = "0132350882"
};

Book book2 = new Book
{
    name = "Introduction to Algorithms",
    author = new string[]
    {
    "Thomas H.Cormen",
    "Charles E.Leiserson",
    "Ronald L.Rivest",
    "Clifford Stein"
    },
    publishingDate = new DateOnly(2009, 7, 31),
    ISBN10 = "0262033844"
};

Book book3 = new Book
{
    name = "The Pragmatic Programmer: Your Journey to Mastery",
    author = new string[]
    {
    "Andrew Hunt",
    "David Thomas"
    },
    publishingDate = new DateOnly(1999, 10, 30),
    ISBN10 = "020161622X"
};

static void PrintBookInformation(List<Book> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(i + 1 + ".");
        Console.WriteLine("Book Name: " + list[i].name);

        if (list[i].author.Count() > 1)
        {
            Console.Write(list[i].author[0]);
            for (int j = 1; j < list[i].author.Count(); j++)
            {
                Console.Write(", " + list[i].author[j]);
            }
        }
        else if (list[i].author.Count() == 1)
        {
            Console.Write(list[i].author[0]);
        }
        Console.WriteLine();

        Console.WriteLine("Published: " + list[i].publishingDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("ISBN10: " + list[i].ISBN10);
        Console.WriteLine();
    }
}

List<Book> books = new();
books.Add(book1);
books.Add(book2);
books.Add(book3);

PrintBookInformation(books);

string codeExample17 = @"
class Book
{
        public string name = "";
        public string[] author = { };
        public DateOnly publishingDate;
        public string ISBN10 = "";
}

Book book1 = new Book
{
    name = ""Clean Code: A Handbook of Agile Software Craftsmanship"",
    author = new string[] { ""Robert C. Martin (Uncle Bob)"" },
    publishingDate = new DateOnly(2008, 8, 11),
    ISBN10 = ""0132350882""
};

Book book2 = new Book
{
    name = ""Introduction to Algorithms"",
    author = new string[]
    {
    ""Thomas H.Cormen"",
    ""Charles E.Leiserson"",
    ""Ronald L.Rivest"",
    ""Clifford Stein""
    },
    publishingDate = new DateOnly(2009, 7, 31),
    ISBN10 = ""0262033844""
};

Book book3 = new Book
{
    name = ""The Pragmatic Programmer: Your Journey to Mastery"",
    author = new string[]
    {
    ""Andrew Hunt"",
    ""David Thomas""
    },
    publishingDate = new DateOnly(1999, 10, 30),
    ISBN10 = ""020161622X""
};

static void PrintBookInformation(List<Book> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(i + 1 + ""."");
        Console.WriteLine(""Book Name: "" + list[i].name);

        if (list[i].author.Count() > 1)
        {
            Console.Write(list[i].author[0]);
            for (int j = 1; j < list[i].author.Count(); j++)
            {
                Console.Write("", "" + list[i].author[j]);
            }
        }
        else if (list[i].author.Count() == 1)
        {
            Console.Write(list[i].author[0]);
        }
        Console.WriteLine();

        Console.WriteLine(""Published: "" + list[i].publishingDate.ToString(""dd/MM/yyyy""));
        Console.WriteLine(""ISBN10: "" + list[i].ISBN10);
        Console.WriteLine();
    }
}

List<Book> books = new();
books.Add(book1);
books.Add(book2);
books.Add(book3);

PrintBookInformation(books);
";

string codeExplanation17 = @"
This code defines a class named 'Book' with properties for 
book details such as name, author(s), publishing date, and 
ISBN-10 number. Three instances of the 'Book' class are created,
each representing a different book, & added to a List called 
'books'. The 'PrintBookInformation' method is then defined to 
traverse the list & display the book details for each book on 
the console. It cleverly handles the authors' names array by 
checking its count, ensuring the names are displayed correctly
whether there's a single author or multiple authors. Overall, 
this example illustrates the fundamental concepts of C# classes, 
objects, object instantiation, list usage, & array traversal. 
";

Console.WriteLine(codeExample17);
Console.WriteLine(codeExplanation17);






Console.WriteLine();
Console.WriteLine("18. Use Constructors in C#");
Console.WriteLine();

Computer computer1 = new Computer("Laptop", "Dell", "XPS 13 ", "Intel Core i7-1165G7 (11th Gen)", 16384, 512 * 1024);
Computer computer2 = new Computer("Desktop", "HP", "Pavilion", "AMD Ryzen 9 5900X", 32768, 3000 * 1024);
Computer computer3 = new Computer("All-in-one PC", "Apple", "iMac 24-inch", "Apple M1", 8192, 256 * 1024);

List<Computer> listOfComputers = new();
listOfComputers.Add(computer1);
listOfComputers.Add(computer2);
listOfComputers.Add(computer3);

static Computer findComputerWithHighestStorageCapacity(List<Computer> list)
{
    Computer result = list[0];
    foreach (Computer computer in list)
    {
        if (computer.StorageCapacity > result.StorageCapacity)
        {
            result = computer;
        }
    }

    return result;
}

Computer query = findComputerWithHighestStorageCapacity(listOfComputers);
Console.WriteLine("The computer with the highest storage capacity is the:");
Console.WriteLine(query.Brand + " " + query.Model + " with " + query.StorageCapacity / 1024 + " GB storage space.");

string codeExample18 = @"
class Computer
{
    public string Type { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Processor { get; set; }
    public int Ram { get; set; }
    public int StorageCapacity { get; set; }
    public Computer(string type, string brand, string model, string processor, int ram, int storageCapacity)
    {
        this.Type = type;
        this.Brand = brand;
        this.Model = model;
        this.Processor = processor;
        this.Ram = ram;
        this.StorageCapacity = storageCapacity;
    }
 }

List<Computer> listOfComputers = new();
listOfComputers.Add(computer1);
listOfComputers.Add(computer2);
listOfComputers.Add(computer3);

static Computer findComputerWithHighestStorageCapacity(List<Computer> list)
{
    Computer result = list[0];
    foreach (Computer computer in list)
    {
        if (computer.StorageCapacity > result.StorageCapacity)
        {
            result = computer;
        }
    }

    return result;
}

Computer query = findComputerWithHighestStorageCapacity(listOfComputers);
Console.WriteLine(""The computer with the highest storage capacity is the:"");
Console.WriteLine(query.Brand + "" "" + query.Model + "" with "" + query.StorageCapacity / 1024 + "" GB storage space."")
";

string codeExplanation18 = @"
This C# code defines a 'Computer' class with properties 
representing computer details. The class has a constructor 
for convenient object initialization. Three 'Computer' objects 
are created & added to a 'List<Computer>'. The static method 
'findComputerWithHighestStorageCapacity' finds the computer with 
the largest storage capacity by iterating through the list. The 
result is printed to the console. Using a class constructor 
streamlines object creation & ensures objects are in a valid 
state upon instantiation, promoting code reusability & 
maintainability.
";

Console.WriteLine(codeExample18);
Console.WriteLine(codeExplanation18);






Console.WriteLine();
Console.WriteLine("19. Define Object Methods");
Console.WriteLine();

static void printStudentsWithScholarship(List<Student> list)
{
    foreach (Student student in list)
    {
        if (student.HasScholarship())
        {
            Console.WriteLine(student.Name + " is on a scholarship.");
        }
    }
}

List<Student> listOfStudents = new();
for (int i = 0; i < 5; i++)
{
    Random random = new();
    int year = random.Next(1950, 2006);
    int month = random.Next(1, 13);
    int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);

    Student newStudent = new Student(
        Guid.NewGuid().ToString("N").Substring(0, 10),
        Faker.Name.FullName(NameFormats.Standard),
        new DateTime(year, month, day),
        Convert.ToBoolean(random.Next(2))
    );

    listOfStudents.Add(newStudent);
}

printStudentsWithScholarship(listOfStudents);


string codeExample19 = @"
class Student
{
    private string StudentId { get; set; }
    public string? Name { get; set; }
    private DateTime DateOfBirth { get; set; }
    private bool IsOnScholarship { get; set; }

    public Student(string studentId, string name, DateTime dateOfBirth, bool isOnScholarship)
    {
        this.StudentId = studentId;
        this.Name = name;
        this.DateOfBirth = dateOfBirth;
        this.IsOnScholarship = isOnScholarship;
    }
    public bool HasScholarship()
    {
        return this.IsOnScholarship;
    }
}

static void printStudentsWithScholarship(List<Student> list)
{
    foreach (Student student in list)
    {
        if (student.HasScholarship())
        {
            Console.WriteLine(student.Name + "" is on a scholarship."");
        }
    }
}

List<Student> listOfStudents = new();
for (int i = 0; i < 5; i++)
{
    Random random = new();
    int year = random.Next(1950, 2006);
    int month = random.Next(1, 13);
    int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);

    Student newStudent = new Student(
        Guid.NewGuid().ToString(""N"").Substring(0, 10),
        Faker.Name.FullName(NameFormats.Standard),
        new DateTime(year, month, day),
        Convert.ToBoolean(random.Next(2))
    );

    listOfStudents.Add(newStudent);
}

printStudentsWithScholarship(listOfStudents);
";

string codeExplanation19 = @"
This code defines a C# class called 'Student' with properties 
for 'StudentId', 'Name', 'DateOfBirth', & 'IsOnScholarship'. 
It has a constructor to initialize these properties when a new 
'Student' object is created. Additionally, it includes a public 
method called 'HasScholarship()' that returns true if the student 
is on a scholarship, based on the value of the 'IsOnScholarship '
property. The code also contains a method called 
'printStudentsWithScholarship', which takes a list of students 
& prints the names of those who are on a scholarship. To create 
a 'listOfStudents', the code uses a loop to generate random values 
for each student's name, date of birth, scholarship status, and a 
unique identifier (StudentId) using the Guid class and Faker 
library. 
";

Console.WriteLine(codeExample19);
Console.WriteLine(codeExplanation19);






Console.WriteLine();
Console.WriteLine("20. Getters and Setters in Classes");
Console.WriteLine();

List<Car> cars = new()
{
    new Car("Toyota", "Camry", 2018, 25000.00),
    new Car("Ford", "Mustang", 2020, -50000.00),
    new Car("Honda", "Civic", 2019, 20500.00),
    new Car("BMW", "X5", 2021, 70000.00),
    new Car("Hyundai", "Tucson", 2017, -18000.00)
};

static int countInvalidCarEntries(List<Car> list)
{
    int count = 0;
    foreach (Car car in list)
    {
        if (car.Price <= 0 && car.IsAvailable == false)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(
    "The number of invalid card entries found = " +
    countInvalidCarEntries(cars)
);

string codeExample20 = @"
class Car
{
    private string Make { get; set; }
    private string Model { get; set; }
    private int Year { get; set; }
    private double price { get; set; }
    public bool IsAvailable { get; set; }

    public Car(string make, string model, int year, double price)
    {
        Make = make;
        Model = model;
        Year = year;
        Price = price;
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                price = 0;
                IsAvailable = false;
            }
            else
            {
                price = value;
                IsAvailable = true;
            }

        }
    }
}

List<Car> cars = new()
{
    new Car(""Toyota"", ""Camry"", 2018, 25000.00),
    new Car(""Ford"", ""Mustang"", 2020, -50000.00),
    new Car(""Honda"", ""Civic"", 2019, 20500.00),
    new Car(""BMW"", ""X5"", 2021, 70000.00),
    new Car(""Hyundai"", ""Tucson"", 2017, -18000.00)
};

static int countInvalidCarEntries(List<Car> list)
{
    int count = 0;
    foreach (Car car in list)
    {
        if (car.Price <= 0 && car.IsAvailable == false)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(
    ""The number of invalid card entries found = "" +
    countInvalidCarEntries(cars)
);
";

string codeExplanation20 = @"
This C# code defines a 'Car' class with mostly private members, 
including 'Make', 'Model', 'Year', & a private 'price'. The 
'Price' property has a smart setter that automatically updates 
the 'IsAvailable' boolean flag based on whether the provided price 
is valid (greater than 0) or not. If the price is invalid, the car 
is marked as unavailable. The code then utilizes a method called 
'countInvalidCarEntries' to iterate through a list of 'Car' objects 
& count the number of invalid entries, i.e., cars with a price of 0 
or less and marked as unavailable. The method uses the public 'Price' 
property to access the price & considers the 'IsAvailable' flag to 
ensure the correct count. Finally, the code displays the number of 
invalid car entries to the user.
";

Console.WriteLine(codeExample20);
Console.WriteLine(codeExplanation20);






Console.WriteLine();
Console.WriteLine("21. Static Class Attributes");
Console.WriteLine();

List<PoemEntry> poemEntries = new List<PoemEntry>
{
    new PoemEntry(
        Faker.Name.FullName(NameFormats.Standard), "Autumn Breeze",
        "Leaves fall gently, dance with ease,\nAutumn breeze whispers in the trees.", true
    ),
    new PoemEntry(
        "Jane Smith", "A Moonlit Night", "Beneath the moon's soft silver light,\nShadows dance, embracing night.", false
    ),
    new PoemEntry(
        "Anonymous", "Lost Dreams",
        "In the depths of twilight's gleam,\nLost dreams wander, seeking a seam.", true
    )
};

Console.WriteLine(
    "The total number of poem entries received so far = " +
    PoemEntry.getTotalEntries()
);

string codeExample21 = @"
class PoemEntry
{
    private string? PoetName { get; set; }
    private string? PoemTitle { get; set; }
    private string? Poem { get; set; }
    private bool IsOriginal { get; set; }
    private static int EntryCount { get; set; }
    public PoemEntry(string poetName, string poemTitle, string poem, bool isOriginal)
    {
        PoetName = poetName;
        PoemTitle = poemTitle;
        Poem = poem;
        IsOriginal = isOriginal;
        EntryCount++;
    }

    public static int getTotalEntries()
    {
        return EntryCount;
    }
}

List<PoemEntry> poemEntries = new List<PoemEntry>
{
    new PoemEntry(
        Faker.Name.FullName(NameFormats.Standard), ""Autumn Breeze"",
        ""Leaves fall gently, dance with ease,\nAutumn breeze whispers in the trees."", true
    ),
    new PoemEntry(
        ""Jane Smith"", ""A Moonlit Night"", ""Beneath the moon's soft silver light,\nShadows dance, embracing night."", false
    ),
    new PoemEntry(
        ""Anonymous"", ""Lost Dreams"",
        ""In the depths of twilight's gleam,\nLost dreams wander, seeking a seam."", true
    )
};

Console.WriteLine(
    ""The total number of poem entries received so far = "" +
    PoemEntry.getTotalEntries()
);
";

string codeExplanation21 = @"
This C# code defines a 'PoemEntry' class representing poem entries. 
It uses a static field 'EntryCount' to keep track of the total number 
of entries created. Each time a new 'PoemEntry' instance is constructed, 
the constructor increments 'EntryCount'. The static method 'getTotalEntries()' 
allows access to the current value of 'EntryCount' without creating an 
instance of the class. This approach ensures a global count of all poem 
entries is maintained conveniently, making it easy to monitor the number 
of entries generated from anywhere in the program.
";

Console.WriteLine(codeExample21);
Console.WriteLine(codeExplanation21);






Console.WriteLine();
Console.WriteLine("22. Utilize Static Classes");
Console.WriteLine();

List<Person> peopleList = new();
string testMessage = "Test message";
Logger.LogListType(peopleList);
Logger.DebugLog(testMessage);

string codeExample22 = @"
static class Logger
{
    public static void LogListType<T>(List<T> list)
    {
        Console.WriteLine($""List type: { typeof(T).Name}"");
    }

    public static void DebugLog(string message)
    {
        Console.WriteLine($""[DEBUG]: {message}"");
    }
}

List<Person> peopleList = new();
string testMessage = ""Test message"";
Logger.LogListType(peopleList);
Logger.DebugLog(testMessage);
";
string codeExplanation22 = @"
The 'Logger' static class in this C# code demonstrates the use of static 
methods for logging & debugging purposes. By implementing static methods, 
it provides a convenient & direct way to access these functionalities 
throughout the application without needing to create instances. This approach 
is especially useful in C# .NET web applications, where the static class can 
serve as a utility class, offering common functionality like logging different 
types and levels of messages efficiently & with global access. The class can be 
expanded conveniently by adding more logging methods & enhancing its features as 
needed, promoting code reusability & maintainability. However, caution should 
be exercised to avoid excessive use of statics, as it may lead to tight coupling 
& hinder unit testing.
";

Console.WriteLine(codeExample22);
Console.WriteLine(codeExplanation22);






Console.WriteLine();
Console.WriteLine("23. Implement Inheritance");
Console.WriteLine();

List<Animal> animalList = new()
{
     new Animal("Charlie",2,10),
     new Dog("Picsou",3,20),
     new Cat("Gigi",1,4)
};

foreach (Animal animal in animalList)
{
    string animalType = animal.GetType().Name.ToLower() == "animal" ? "(unknown)" : animal.GetType().Name.ToLower();
    Console.WriteLine($"{animal.Name} is a {animalType} and {animal.AnimalSound()}");
}

string codeExample23 = @"
class Animal
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    public Animal(string? name, int age, int weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }
    public virtual string AnimalSound()
    {
        return ""makes (unknown) sounds!"";
    }
}

class Dog : Animal
{
    public Dog(string? name, int age, int weight) : base(name, age, weight) { }
    public override string AnimalSound()
    {
        return ""barks!"";
    }
}

class Cat : Animal
{
    public Cat(string? name, int age, int weight) : base(name, age, weight) { }
    public override string AnimalSound()
    {
        return ""meows!"";
    }
}

List<Animal> animalList = new List<Animal> {
     new Animal(""Charlie"",2,10),
     new Dog(""Picsou"",3,20),
     new Cat(""Gigi"",1,4)
};

foreach (Animal animal in animalList)
{
    string animalType = animal.GetType().Name.ToLower() == ""animal"" ? ""(unknown)"" : animal.GetType().Name.ToLower();
    Console.WriteLine($""{animal.Name} is a {animalType} and {animal.AnimalSound()}"");
}
";

string codeExplanation23 = @"
This C# code demonstrates the use of inheritance to create a superclass 
'Animal', & two subclasses 'Dog' and 'Cat', each inheriting properties 
& methods from 'Animal'. By utilizing 'virtual' & 'override' keywords, 
specific animal sounds are defined for 'Dog' & 'Cat', enabling the 
identification & classification of each animal type during the iteration 
through the 'animalList'. The code showcases the benefits of inheritance 
in organizing & reusing code, allowing for straightforward implementation 
& extension of new animal types with their unique characteristics.
";

Console.WriteLine(codeExample23);
Console.WriteLine(codeExplanation23);