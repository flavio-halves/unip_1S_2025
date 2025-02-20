using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao // Declaração de um namespace chamado "Abstracao"
{
    class Program // Declaração da classe Program
    {
        static void Main(string[] args) // Método principal, ponto de entrada do programa
        {
            // Cria uma nova instância da classe Caneta, passando "Azul" como argumento para o construtor
            Caneta minhaCaneta = new Caneta("Azul");

            // Chama o método Destampar() da instância minhaCaneta da classe Caneta
            minhaCaneta.Destampar();

            // Chama o método Escrever() da instância minhaCaneta da classe Caneta, passando "Olá, mundo!" como argumento
            minhaCaneta.Escrever("Olá, mundo!");

            // Chama o método Tampar() da instância minhaCaneta da classe Caneta
            minhaCaneta.Tampar();

            // Aguarda a entrada do usuário antes de encerrar o programa
            Console.ReadLine();
        }
    }
}