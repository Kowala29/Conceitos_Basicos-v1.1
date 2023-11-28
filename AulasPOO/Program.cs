/*
 * O projeto devera conter uma classe cliente que pussiu nome, endereço, telefone e data de nascimento
 * a classe cliente será criada dentro de uma pasta chamada Model
 * Deverá ser possivel verificar a idade do cliente a partir de um método da própria classe
 */

using AulasPOO.Model;

/*
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

var conta1 = new Conta();
//conta1.NumeroConta = 123456;
//conta1.Saldo = 1000.99m;
//Console.WriteLine($"Conta {conta1.NumeroConta} com saldo de {conta1.Saldo}");

var cliente1 = new Cliente("Fulano", "12345678901");

conta1.Titular = cliente1;
Console.WriteLine($"Conta {conta1.NumeroConta} pertence à {conta1.Titular.Nome}");
*/

var conta2 = new Conta(1213,1000);

Console.WriteLine($"Saldo {conta2.Saldo}");
conta2.Deposito(1000);
Console.WriteLine($"Saldo {conta2.Saldo}");
conta2.Saque(500);
Console.WriteLine($"Saldo {conta2.Saldo}");