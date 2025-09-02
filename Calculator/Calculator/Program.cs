Console.Clear();
Console.WriteLine("First Number:");
string? input1 = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input1))
{
	Console.WriteLine("Invalid input for first number.");
	return;
}
float num1 = float.Parse(input1);

Console.WriteLine("Second Number:");
string? input2 = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input2))
{
	Console.WriteLine("Invalid input for second number.");
	return;
}
float num2 = float.Parse(input2);

float sum = num1 + num2;
Console.WriteLine($"The sum of {num1} and {num2} is {sum}");