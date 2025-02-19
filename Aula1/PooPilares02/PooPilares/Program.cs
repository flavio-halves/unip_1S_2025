using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPilares
{
    // Polimorfismo: aumenta a flexibilidade e a extensibilidade do código ao permitir que
    // um método seja usado de diferentes maneiras dependendo do contexto. Isso é especialmente
    // útil quando se lida com classes derivadas, onde diferentes implementações de um método podem
    // ser aplicadas a diferentes tipos de objeto, simplificando a chamada de métodos e facilitando
    // a adição de novos tipos de objeto sem afetar o restante do código.

    class Program // Declaração da classe Program
    {
        static void Main(string[] args) // Método principal, ponto de entrada do programa
        {
            Caneta minhaCaneta = new Caneta("Azul"); // Cria uma nova instância da classe Caneta com a cor "Azul"
            minhaCaneta.Destampar(); // Chama o método Destampar() da instância minhaCaneta da classe Caneta
            minhaCaneta.Escrever("Olá, mundo!"); // Chama o método Escrever() da instância minhaCaneta da classe Caneta
            minhaCaneta.Tampar(); // Chama o método Tampar() da instância minhaCaneta da classe Caneta

            Pessoa pessoa = new Pessoa("João", 30); // Cria uma nova instância da classe Pessoa com o nome "João" e idade 30
            pessoa.ExibirInformacoes(); // Chama o método ExibirInformacoes() da instância pessoa da classe Pessoa

            Estudante estudante = new Estudante("Maria", 20, "Engenharia"); // Cria uma nova instância da classe Estudante com o nome "Maria", idade 20 e curso "Engenharia"
            estudante.ExibirInformacoes(); // Chama o método ExibirInformacoes() da instância estudante da classe Estudante

            Console.ReadLine(); // Aguarda a entrada do usuário antes de encerrar o programa
        }
    }
}
