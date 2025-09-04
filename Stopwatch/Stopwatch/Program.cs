#pragma warning disable CS8602 // Dereference of a possibly null reference.
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S - Seconds => 10s = 10 seconds");
    Console.WriteLine("M - Minutes => 1m = 1 minute");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("How much time do you want to count?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data[^1..]);
    int time = int.Parse(data[..^1]);
    Console.WriteLine(type);
    Console.WriteLine(time);
    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;
    if (time == 0)
        Environment.Exit(0);

    PreStart(time * multiplier);    
}

static void PreStart(int time = 3)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Go!");
    Thread.Sleep(1000);
    Start(time);
}

static void Start(int time = 10)
{
    int currentTime = 0;

    while (currentTime < time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finished!");
    Thread.Sleep(2500);
    Menu();
}
#pragma warning restore CS8602 // Dereference of a possibly null reference.