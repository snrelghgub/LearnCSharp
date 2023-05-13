
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Learn C#");
Console.ResetColor();

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
strings that will hold the formatted date and time values, respectively. 
The 'ToString()' method is used to extract the month data from 
'currentTime' using ""MM"" and the minutes data using ""mm"" etc. 
The Sleep method sets a pause to the while loop for one second, 
allowing the clock to update correctly. The 'Console.Clear()' method 
is used to clear the console screen to update the clock every second. 
The final result is a clock that displays both the 'date' and 'time' accurately. 
The 'Sleep()' method is part of the System.Threading namespace in C#. The 'WriteLine' 
method comes from the Console class in C#, which is part of the .Net Framework 
class library in the System namespace. Other examples of classes 
in the System namespace are 'DateTime' and 'ConsoleColor'.";

Console.WriteLine(codeExplanation2);
