using Faker;
using System.Text.RegularExpressions;

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
Console.WriteLine("4. Work with strings");
Console.WriteLine();

// Person 1
string name1 = Faker.Name.FullName(NameFormats.Standard);
string address1 = Faker.Address.StreetAddress() + ", " + Faker.Address.City() + ", " + Faker.Address.UsState() + ", " + Faker.Address.ZipCode();
string person1 = String.Concat("Name: ", name1,"\nAddress: ", address1);

// Person 2
string name2 = Faker.Name.FullName(NameFormats.Standard);
string landlineNumber2 = Faker.Phone.Number().Replace(".", "-").Split('x')[0].Trim();
string person2 = String.Concat("Name: ", name2, "\nLandline number: ", landlineNumber2);

// Person 3
string name3 = Faker.Name.FullName(NameFormats.Standard);
string address3 = Faker.Address.StreetAddress() + ", " + Faker.Address.City() + ", " + Faker.Address.UsState() + ", " + Faker.Address.ZipCode();
string landlineNumber3 = Faker.Phone.Number().Replace(".", "-").Split('x')[0].Trim();
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
