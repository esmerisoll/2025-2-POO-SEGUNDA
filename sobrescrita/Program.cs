// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

CultureInfo.CurrentCulture = new CultureInfo("en-US");

Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(100);

Controle.WriteLine("-- Cartao de debito --");

Cartao cartaoDebito = new CartaoDebito();
CartaoDebito.Debitar(100);