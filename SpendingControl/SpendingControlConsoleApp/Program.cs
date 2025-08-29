// See https://aka.ms/new-console-template for more information
using SpendingControlConsoleApp.Entities;

var user = new User(1, "John Smith", "john@email.com", "", DateTime.Now.AddYears(-5));
var category = new Category(1, "Food", "Expenses with food and supermarket", "Expense", DateTime.Now.AddYears(-5));
var expense = new Expense(1, 1, category.Id, 150.75, "Credit Card", DateTime.Now);
var income = new Income(1, 1, 1, 3500.00, DateTime.Now);
var creditCard = new CreditCard(1, 1, "My Card", DateTime.Now.AddYears(2), "Visa", 5000.00, DateTime.Now.AddMonths(1), DateTime.Now);
var financialGoal = new FinancialGoal(1, 1, "Trip", 10000.00, 2500.00, DateTime.Now.AddMonths(12), "International trip", DateTime.Now);

Console.WriteLine($"User: {user.Name}, Email: {user.Email}, Registration: {user.RegistrationDate:d}");
Console.WriteLine($"Category: {category.Name}, Description: {category.Description}");
Console.WriteLine($"Expense: {expense.Description}, Amount: {expense.Amount:C}, Date: {expense.Date:d}");
Console.WriteLine($"Income: {income.Description}, Amount: {income.Amount:C}, Date: {income.Date:d}");
Console.WriteLine($"Credit Card: {creditCard.Name}, Brand: {creditCard.Brand}, Limit: {creditCard.Limit:C}");
Console.WriteLine(
    $"Financial Goal: {financialGoal.Name}, Goal Amount: {financialGoal.GoalAmount:C}, Current Amount: {financialGoal.CurrentAmount:C}"
    );

user.UpdatePersonalInfo("Jane Doe", "jane@email.com");
user.UpdatePassword("newpassword123");
category.UpdateCategory("Supermarket", "All supermarket expenses", "Expense");
expense.UpdateExpense(category.Id, 50.25, "Debit Card");
income.UpdateIncome(category.Id, 500.00);
creditCard.UpdateCreditCard("My New Card", DateTime.Now.AddYears(3), "Mastercard", 7000.00, DateTime.Now.AddMonths(2));
financialGoal.UpdateFinancialGoal("Car", 30000.00, 5000.00, DateTime.Now.AddMonths(24), "Buy a new car");

Console.WriteLine("\n--- Após atualização ---\n");
Console.WriteLine($"User: {user.Name}, Email: {user.Email}");
Console.WriteLine($"Category: {category.Name}, Description: {category.Description}");
Console.WriteLine($"Expense: {expense.Description}, Amount: {expense.Amount:C}, Payment: {expense.PaymentMethod}");
Console.WriteLine($"Income: {income.Description}, Amount: {income.Amount:C}");
Console.WriteLine($"Credit Card: {creditCard.Name}, Brand: {creditCard.Brand}, Limit: {creditCard.Limit:C}");
Console.WriteLine(
    $"Financial Goal: {financialGoal.Name}, Goal Amount: {financialGoal.GoalAmount:C}, Current Amount: {financialGoal.CurrentAmount:C}"
    );
