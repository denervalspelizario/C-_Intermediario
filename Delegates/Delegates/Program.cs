// See https://aka.ms/new-console-template for more information
using Delegates;

Console.WriteLine("## Delegates ##");

Calculadora calc = new Calculadora();

var resultado = calc.Somar(10,40);

Console.WriteLine(resultado);

/* Primeira FORMA
   instanciando meu Delegate ao objeto calcDelegate e adicionando
   o metodo Somar de Calculador() */
DelegateCalculadora calcDelegate = new DelegateCalculadora(calc.Somar);

// invocando o metodo soma que passou de calc para o calcDelegate
var resultado2 = calcDelegate.Invoke(10,40);
Console.WriteLine(resultado2);


/* Segunda Forma
   seria adicionar de forma direta*/
DelegateCalculadora calcDelegate02 = calc.Somar;

// invocando o metodo Soma sem o Invoke que passou de calc para o calcDelegate02
var resultado3 = calcDelegate02(10, 40);
Console.WriteLine(resultado3);


Console.ReadKey();

// Declarando meu Delegate
public delegate double DelegateCalculadora(double x, double y);