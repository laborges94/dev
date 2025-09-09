Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Open File");
    Console.WriteLine("2. Create File");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");
    short option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 1:
            OpenFile();
            break;
        case 2:
            CreateFile();
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

static void OpenFile()
{
    Console.Clear();
    Console.Write("Enter the file path: ");
    string path = Console.ReadLine()!;
    using (var file = new StreamReader(path))
    {
        string content = file.ReadToEnd();
        Console.WriteLine(content);
    }

    Console.WriteLine();
    Console.WriteLine("Press any key to return to the menu.");
    Console.ReadKey();

    Menu();
}

static void CreateFile()
{
    Console.Clear();
    Console.WriteLine("Enter your text below (type ESC to finish):");

    string text = "";
    string line;

    do
    {
        line = Console.ReadLine()!;
        text += line + Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Console.Write("Enter the file path to save: ");

    string path = Console.ReadLine()!;
    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"File {path} saved successfully!");
    Console.WriteLine("Press any key to return to the menu.");
    Console.ReadKey();

    Menu();
}