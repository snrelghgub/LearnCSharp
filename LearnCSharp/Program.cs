while (true)
{
    DateTime currentTime = DateTime.Now;
    string date = currentTime.ToString("dd/MM/yyyy");
    string time = currentTime.ToString("hh:mm:ss tt");

    Console.WriteLine(date + " - " + time);

    Thread.Sleep(1000);
    Console.Clear();
}

