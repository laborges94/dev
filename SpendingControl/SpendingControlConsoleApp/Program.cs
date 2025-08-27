// See https://aka.ms/new-console-template for more information
using ControleGastosConsoleApp.Entities;

// Example usage of the classes
var user = new User(1, "John Smith", "john@email.com", "", DateTime.Now.AddYears(-5));
var category = new Category(1, "Food", "Expenses with food and supermarket", "Expense", DateTime.Now.AddYears(-5));

var expense = new Expense(1, 1, category.Id, "Supermarket", 150.75m, "Credit Card", DateTime.Now);
var income = new Income(1, 1, 1, "Salary", 3500.00m, DateTime.Now);
var creditCard = new CreditCard(1, 1, "My Card", DateTime.Now.AddYears(2), "Visa", 5000.00m, DateTime.Now.AddMonths(1));
var financialGoal = new FinancialGoal(1, 1, "Trip", 10000.00m, 2500.00m, DateTime.Now.AddMonths(12), "International trip");

Console.WriteLine($"User: {user.Name}, Email: {user.Email}, Registration: {user.RegistrationDate:d}");
Console.WriteLine($"Category: {category.Name}, Description: {category.Description}");

Console.WriteLine($"Expense: {expense.Description}, Amount: {expense.Amount:C}, Date: {expense.Date:d}");
Console.WriteLine($"Income: {income.Description}, Amount: {income.Amount:C}, Date: {income.Date:d}");
Console.WriteLine($"Credit Card: {creditCard.Name}, Brand: {creditCard.Brand}, Limit: {creditCard.Limit:C}");
Console.WriteLine($"Financial Goal: {financialGoal.Name}, Goal Amount: {financialGoal.GoalAmount:C}, Current Amount: {financialGoal.CurrentAmount:C}");
