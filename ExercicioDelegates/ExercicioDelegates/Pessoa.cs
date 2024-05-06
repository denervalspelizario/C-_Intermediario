using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDelegates
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        // construtor
        public Pessoa(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Metodo static(podemos usar sem precisar instanciar) que retorna uma list de pessoas
        public static List<Pessoa> GetPessoas()
        {
            // ja estou criando a List e adicionando as pessoas
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa("João",20),
                new Pessoa("Maria",18),
                new Pessoa("Pedro",25),
                new Pessoa("Carlos",15),
                new Pessoa("Ana",17)
            };
            // retornando as pessoas
            return pessoas;
        }
    }
}
