Console.Clear();

Menu();

static void Menu()
{
	Console.Clear();
	Console.WriteLine("Select an option:");
	Console.WriteLine("--------------------");
	Console.WriteLine("1. Pocket Calculator");
	Console.WriteLine("2. Solve Expression");
	Console.WriteLine("--------------------");
	Console.WriteLine("Quick Operations:");
	Console.WriteLine("--------------------");
	Console.WriteLine("3. Sum (List of numbers)");
	Console.WriteLine("4. Subtract (A-B)");
	Console.WriteLine("5. Multiply (List of numbers)");
	Console.WriteLine("6. Divide (A/B where B cannot be 0)");
	Console.WriteLine("7. Power (A^B)");
	Console.WriteLine("8. Square Root (A^(1/2))");
	Console.WriteLine("9. Percentage (A is the base, B is the percentage)");
	Console.WriteLine("10. Arithmetic Mean ((A+B)/2)");
	Console.WriteLine("0. Exit");
	Console.WriteLine("--------------------");
	Console.Write("Enter your choice: ");

	short choice = short.Parse(Console.ReadLine()!);

	switch (choice)
	{
		case 1:
			// Simple Calculator
			Console.WriteLine("Simple Calculator selected.");
			Console.WriteLine("This feature is under development.");
			Console.ReadKey();
			Menu();
			break;
		case 2:
			// Expression
			Console.WriteLine("Expression selected.");
			Console.WriteLine("This feature is under development.");
			Console.ReadKey();
			Menu();
			break;
		case 3:
			Sum(GetNumbers());
			break;
		case 4:
			Subtract(FirstNumber(), SecondNumber());
			break;
		case 5:
			Multiply(FirstNumber(), SecondNumber());
			break;
		case 6:
			Divide(FirstNumber(), SecondNumber());
			break;
		case 7:
			Power(FirstNumber(), SecondNumber());
			break;
		case 8:
			Root(FirstNumber(), SecondNumber());
			break;
		case 9:
			Percentage(FirstNumber(), SecondNumber());
			break;
		case 10:
			ArithmeticMean(FirstNumber(), SecondNumber());
			break;
		case 0:
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

static IEnumerable<float> GetNumbers()
{
	var numbers = new List<float>();

	while (true)
	{
		Console.WriteLine("Enter a number (or type '=' to finish):");
		string? input = Console.ReadLine();
		if (string.IsNullOrWhiteSpace(input))
		{
			Console.WriteLine("Invalid input. Please enter a number or '='.");
			continue;
		}
		if (input.Equals("=", StringComparison.CurrentCultureIgnoreCase))
			break;

		if (float.TryParse(input, out float number))
			numbers.Add(number);
		else
			Console.WriteLine("Invalid number. Please try again.");
	}

	return numbers;
}

static void Sum(IEnumerable<float> numbers)
{
	float result = numbers.Sum();

	Console.WriteLine($"The sum of:");
	
	foreach (var number in numbers)
		Console.WriteLine($" - {number}");

	Console.WriteLine($"is {result}");
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
	float result = a / 100 * b;
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