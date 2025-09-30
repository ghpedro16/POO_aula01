// See https://aka.ms/new-console-template for more information

using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("pt-PT");

Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(100);

Console.WriteLine("-- Cartao de Débito --");
Cartao cartaoDebito = new CartaoDebito();
cartaoDebito.Debitar(100);

