// See https://aka.ms/new-console-template for more information
using Console.App;
using Console.App.Enums;
using Console.App.Factories.Generator;

var bank = BankGenerator.Generate(BankType.Akbank);
bank.GetPaid(5000);
System.Console.WriteLine("Payment completed.");

