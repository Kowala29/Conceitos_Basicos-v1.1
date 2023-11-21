/*
 * O projeto devera conter uma classe cliente que pussiu nome, endereço, telefone e data de nascimento
 * a classe mcliente será criada dentro de uma pasta chamada Model
 * Deverá ser possivel verificar a idade do cliente a partir de um método da própria classe
 */

using AulasPOO.Model;

Console.WriteLine("Entre com o Nome:");
string nome = Console.ReadLine();

Console.WriteLine("Entre com o Endereço:");
string endereco = Console.ReadLine();

Console.WriteLine("Enre com o telefone:");
int telefone = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com a Data de Nascimento:");
DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

Console.WriteLine(Cliente.IdadeCliente(dataNascimento));

//Crie uma classe Conta, que possua o atributo e propriedade Número e Saldo

var conta1 = new Conta(123456, 1000.99m);
//conta1.NumeroConta = 123456;
//conta1.Saldo = 1000.99m;
Console.WriteLine($"Conta {conta1.NumeroConta} com saldo de {conta1.Saldo}");

