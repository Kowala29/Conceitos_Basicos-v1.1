// See https://aka.ms/new-console-template for more information
using Conceitos_Basicos;
using System.Reflection;

Console.WriteLine("Hello, World!"); // Pra tirar a zica

//Somador somador = new Somador(); // Instancia a classe soma
//var soma = somador.Somar(20, 22); // Chama o objeto de soma

//Console.WriteLine($"Resultado da Soma é {soma}"); // Imprime o resultado da soma

// Crie uma classe que subtraia 2 numeros inteiros
// utilize essa classe

//Subtrair subtrair = new Subtrair(); // Instancia a classe subtrair
//var resultado = subtrair.Subtraia(22, 20); // Chama o objeto subtraia

//Console.WriteLine($"Resultado da Subtração é {subtrair.Subtraia(82,40)}"); // Imprime o resultado da subtração

Console.WriteLine("Entre com o Primeiro Número");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o Segundo Número");
int num2 = Convert.ToInt32(Console.ReadLine());

//Criar uma classe calculadora que vai usar as 4 operações básicas

Calculadora calculadora = new Calculadora();

Console.WriteLine($"Resultado da Soma é {calculadora.Soma(num1, num2)}");

Console.WriteLine($"Resultado da Subtração é {calculadora.Subtracao(num1, num2)}");

Console.WriteLine($"Resultado da Multiplicação é {calculadora.Multiplicacao(num1, num2)}");

Console.WriteLine($"Resultado da Divisão é {calculadora.Divisao(num1, num2)}");


//Fatorial de um número

Fatorial fatorial = new Fatorial();

double n1;

Console.WriteLine("Informe o Número.");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine($"O resultado do Fatorial de {n1} é {fatorial.Fatorial_numero(n1)}");
