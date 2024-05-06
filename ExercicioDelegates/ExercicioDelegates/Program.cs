// See https://aka.ms/new-console-template for more information
using ExercicioDelegates;
using System.Threading.Channels;

Console.WriteLine("## Exercicio Delegates ##");

// Definindo a lista de pessoas
// pegando a lista de pessoas do metodo statico GetPessoas

var listaDePessoas = Pessoa.GetPessoas();

Console.WriteLine("1 - Imprime o nome/idade de cada pessoa usando um delegate Action<Pessoa>");

Action<Pessoa> imprimirNome = x => Console.WriteLine(x.Nome + "  " + x.Idade);

listaDePessoas.ForEach(imprimirNome); // percorrendo a lista de pessoas

Console.WriteLine("2 - Filtra pessoas maiores de 18 anos usando um delegate Predicate<Pessoa>");

Predicate<Pessoa> filtrarPessoa = x => x.Idade > 18;

var pessoasMaiores18anos = listaDePessoas.FindAll(filtrarPessoa);

pessoasMaiores18anos.ForEach(pessoa => Console.WriteLine(pessoa.Nome + " " + pessoa.Idade));

Console.WriteLine("3 - Obtem o nome/idade da pessoa mais velha utilizando um delegate Fun<Pessoa>");

Func<Pessoa, int> obterIdade = p => p.Idade;

int idadeMaxima = listaDePessoas.Max(obterIdade);

var pessoaMaisVelha = listaDePessoas.Find(p => p.Idade == idadeMaxima);

Console.WriteLine("A pessoa mais velha é: " + pessoaMaisVelha.Nome + "idade: " + pessoaMaisVelha.Idade);

Console.ReadKey();