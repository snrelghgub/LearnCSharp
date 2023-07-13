using Faker;
using LearnCSharp;

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Learn C#");
Console.ResetColor();





Console.WriteLine();
Console.WriteLine("1. Draw a shape");
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
        Console.Write("" * "");
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
Console.WriteLine("2. Use variables");
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
Console.WriteLine("3. Use the appropriate data type");
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
Console.WriteLine("4. Work with strings");
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
Console.WriteLine("5. Work with numbers");
Console.WriteLine();

double radius = 5;
double angle = 45;
double radians = angle * (Math.PI / 180);
double xCoordinate = radius * Math.Cos(radians);
double yCoordinate = radius * Math.Sin(radians);
Console.WriteLine(String.Concat(
    "The (x,y) coordinates of a point on a circle with radius ", radius,
    "at an angle of ", angle, "\u00B0 is ",
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
Console.WriteLine("6. Get user input");
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
'Australia' for the country name & 'Sydne'y for the city name are assigned. 
The program then outputs a message to the user displaying the country name, 
city name, & additional text. The important methods used are 'Console.Write()', 
'Console.ReadLine()' & 'String.IsNullOrWhiteSpace()'.
";

Console.WriteLine(codeExplanation6);






Console.WriteLine();
Console.WriteLine("7. Work with arrays");
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
Console.WriteLine("8. Write a simple method");
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
Console.WriteLine("9. Write a more complex method");
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
Console.WriteLine("10. Write if & switch statements");
Console.WriteLine();

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
adult, & senior. The code employs if & switch statements 
to evaluate the age of each person and prints their 
corresponding classification along with their name. 
It demonstrates the usage of conditional & switch-based 
logic to handle different age ranges, providing an 
organized approach for interpreting & categorizing 
individuals based on their age within a group.
";

Console.WriteLine(codeExplanation);






Console.WriteLine();
Console.WriteLine("11. Use a while loop");
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
Console.WriteLine("12. Count the number of specified character in a string");
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
Console.WriteLine("13. Write a for loop");
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
    
";