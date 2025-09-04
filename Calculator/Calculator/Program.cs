Console.Clear();

Menu();

static void Menu()
{
	Console.Clear();
	Console.WriteLine("Select an operation:");
	Console.WriteLine("1. Sum");
	Console.WriteLine("2. Subtract");
	Console.WriteLine("3. Multiply");
	Console.WriteLine("4. Divide");
	Console.WriteLine("5. Power");
	Console.WriteLine("6. Root");
	Console.WriteLine("7. Percentage");
	Console.WriteLine("8. Arithmetic Mean");
	Console.WriteLine("9. Exit");
	Console.WriteLine("--------------------");
	Console.Write("Enter your choice: ");

	short choice = short.Parse(Console.ReadLine()!);

	switch (choice)
	{
		case 1:
			Sum(FirstNumber(), SecondNumber());
			break;
		case 2:
			Subtract(FirstNumber(), SecondNumber());
			break;
		case 3:
			Multiply(FirstNumber(), SecondNumber());
			break;
		case 4:
			Divide(FirstNumber(), SecondNumber());
			break;
		case 5:
			Power(FirstNumber(), SecondNumber());
			break;
		case 6:
			Root(FirstNumber(), SecondNumber());
			break;
		case 7:
			Percentage(FirstNumber(), SecondNumber());
			break;
		case 8:
			ArithmeticMean(FirstNumber(), SecondNumber());
			break;
		case 9:
			Console.WriteLine("Exiting...");
            Environment.Exit(0);
			return;
		default:
			Console.WriteLine("Invalid choice.");
			Console.ReadKey();
			Menu();
			break;
	}
}

static float FirstNumber()
{
	Console.WriteLine("First Number:");
	string? input = Console.ReadLine();
	if (string.IsNullOrWhiteSpace(input))
	{
		Console.WriteLine("Invalid input for first number.");
		return 0;
	}
	return float.Parse(input);
}

static float SecondNumber()
{
	Console.WriteLine("Second Number:");
	string? input = Console.ReadLine();
	if (string.IsNullOrWhiteSpace(input))
	{
		Console.WriteLine("Invalid input for second number.");
		return 0;
	}
	return float.Parse(input);
}

static void Sum(float a, float b)
{
	float result = a + b;
	Console.WriteLine($"The sum of {a} and {b} is {result}");
	Console.ReadKey();
	Menu();
}

static void Subtract(float a, float b)
{
	float result = a - b;
	Console.WriteLine($"The difference of {a} and {b} is {result}");
	Console.ReadKey();
	Menu();
}

static void Multiply(float a, float b)
{
	float result = a * b;
	Console.WriteLine($"The product of {a} and {b} is {result}");
	Console.ReadKey();
	Menu();
}

static void Divide(float a, float b)
{
	if (b == 0)
	{
		Console.WriteLine("Cannot divide by zero.");
		return;
	}
	float result = a / b;
	Console.WriteLine($"The quotient of {a} and {b} is {result}");
	Console.ReadKey();
	Menu();
}

static void Power(float a, float b)
{
	float result = (float)Math.Pow(a, b);
	Console.WriteLine($"{a} raised to the power of {b} is {result}");
	Console.ReadKey();
	Menu();
}

static void Root(float a, float b)
{
	if (b == 0)
	{
		Console.WriteLine("Cannot calculate root with degree zero.");
		return;
	}
	float result = (float)Math.Pow(a, 1 / b);
	Console.WriteLine($"The {b}-th root of {a} is {result}");
	Console.ReadKey();
	Menu();
}

static void Percentage(float a, float b)
{
	float result = (a / 100) * b;
	Console.WriteLine($"{b}% of {a} is {result}");
	Console.ReadKey();
	Menu();
}

static void ArithmeticMean(float a, float b)
{
	float result = (a + b) / 2;
	Console.WriteLine($"The arithmetic mean of {a} and {b} is {result}");
	Console.ReadKey();
	Menu();
}