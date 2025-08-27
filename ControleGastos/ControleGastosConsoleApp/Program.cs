// See https://aka.ms/new-console-template for more information
using ControleGastosConsoleApp.Entidades;

// Simulação de uso das classes
var usuario = new Usuario(1, "João Silva", "joao@email.com", "", DateTime.Now.AddYears(-5));
var categoria = new Categoria(1, "Alimentação", "Despesas com comida e supermercado", "Despesas", DateTime.Now.AddYears(-5));

var gasto = new Gasto(1, 1, categoria.Id, "Supermercado", 150.75m, "Cartão de Crédito", DateTime.Now);
var receita = new Receita(1, 1, 1, "Salário", 3500.00m, DateTime.Now);
var cartao = new CartaoDeCredito(1, 1, "Meu Cartão", DateTime.Now.AddYears(2), "Visa", 5000.00m, DateTime.Now.AddMonths(1));
var objetivo = new ObjetivoFinanceiro(1, 1, "Viagem", 10000.00m, 2500.00m, DateTime.Now.AddMonths(12), "Viagem internacional");

Console.WriteLine($"Usuário: {usuario.Nome}, Email: {usuario.Email}, Cadastro: {usuario.DataCadastro:d}");
Console.WriteLine($"Categoria: {categoria.Nome}, Descrição: {categoria.Descricao}");

Console.WriteLine($"Gasto: {gasto.Descricao}, Valor: {gasto.Valor:C}, Data: {gasto.Data:d}");
Console.WriteLine($"Receita: {receita.Descricao}, Valor: {receita.Valor:C}, Data: {receita.Data:d}");
Console.WriteLine($"Cartão: {cartao.Nome}, Bandeira: {cartao.Bandeira}, Limite: {cartao.Limite:C}");
Console.WriteLine($"Objetivo: {objetivo.Nome}, Valor Objetivo: {objetivo.ValorObjetivo:C}, Valor Atual: {objetivo.ValorAtual:C}");
