using System;// Importa o namespace System para usar classes básicas do .NET
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPilares
{


    // Abstração: simplifica a representação de objetos do mundo real em software e permite que os
    // desenvolvedores se concentrem nas características e comportamentos relevantes dos objetos,
    // enquanto ignoram detalhes desnecessários. Isso simplifica o processo de modelagem e torna o
    // código mais compreensível, gerenciável e flexível.

    public class Caneta // Declaração da classe Caneta
    {
        private string cor; // Variável para armazenar a cor da caneta (abstração de uma propriedade da caneta)
        private bool tampada; // Variável para indicar se a caneta está tampada ou não (abstração de um estado da caneta)

        // Construtor da classe Caneta
        public Caneta(string cor) // Método construtor que inicializa uma nova instância de Caneta
        {
            this.cor = cor; // Inicializa a cor da caneta com o valor passado como argumento (abstração da inicialização de propriedades)
            this.tampada = true; // Inicialmente, a caneta está tampada (abstração de um estado inicial padrão)
        }

        // Método para destampar a caneta (abstração de uma ação específica relacionada à caneta)
        public void Destampar()
        {
            if (tampada) // Verifica se a caneta está tampada (abstração de uma condição)
            {
                tampada = false; // Altera o estado da caneta para destampada (abstração de uma mudança de estado)
                Console.WriteLine("A caneta foi destampada"); // Exibe mensagem informando que a caneta foi destampada (abstração de uma saída de informação)
            }
            else
            {
                Console.WriteLine("A caneta já está destampada"); // Exibe mensagem informando que a caneta já está destampada (abstração de uma saída de informação)
            }
        }

        // Método para escrever com a caneta (abstração de uma ação específica relacionada à caneta)
        public void Escrever(string texto)
        {
            if (!tampada) // Verifica se a caneta está destampada (abstração de uma condição)
            {
                Console.WriteLine("Escrevendo: " + texto); // Exibe o texto a ser escrito (abstração de uma saída de informação)
            }
            else
            {
                Console.WriteLine("Não é possível escrever, a caneta está tampada."); // Exibe mensagem informando que a caneta está tampada (abstração de uma saída de informação)
            }
        }

        // Método para tampar a caneta (abstração de uma ação específica relacionada à caneta)
        public void Tampar()
        {
            if (!tampada) // Verifica se a caneta está destampada (abstração de uma condição)
            {
                tampada = true; // Altera o estado da caneta para tampada (abstração de uma mudança de estado)
                Console.WriteLine("A caneta foi tampada"); // Exibe mensagem informando que a caneta foi tampada (abstração de uma saída de informação)
            }
            else
            {
                Console.WriteLine("A caneta já está tampada"); // Exibe mensagem informando que a caneta já está tampada (abstração de uma saída de informação)
            }
        }
    }

    // Encapsulamento: protege e controla o acesso aos dados e funcionalidades internas de um objeto,
    // evitando modificações não autorizadas e minimizando a dependência entre diferentes partes do código.
    // Isso promove a segurança e a modularidade, permitindo que os detalhes internos de uma classe sejam
    // alterados sem afetar o restante do sistema.

    public class Pessoa // Declaração da classe Pessoa
    {
        // Propriedades públicas com get e set para encapsular o acesso aos dados
        public string Nome { get; set; } // Propriedade pública para armazenar o nome da pessoa
        public int Idade { get; set; } // Propriedade pública para armazenar a idade da pessoa

        // Construtor da classe Pessoa
        public Pessoa(string nome, int idade) // Método construtor que inicializa uma nova instância de Pessoa
        {
            Nome = nome; // Inicializa o nome da pessoa com o valor passado como argumento
            Idade = idade; // Inicializa a idade da pessoa com o valor passado como argumento
        }

        // Método público para exibir informações da pessoa
        public void ExibirInformacoes() // Método público para exibir informações da pessoa
        {
            Console.WriteLine("Nome: " + Nome); // Exibe o nome da pessoa
            Console.WriteLine("Idade: " + Idade); // Exibe a idade da pessoa
        }
    }

    // Herança: promove a reutilização de código e cria hierarquias de classes que compartilham características e
    // comportamentos comuns, além de evitar a duplicação de código ao permitir que uma classe derivada herde atributos
    // e métodos de uma classe-base. A herança facilita a criação de estruturas mais complexas a partir de elementos
    // mais simples, tornando o design mais eficiente e a manutenção mais fácil.

    public class Estudante : Pessoa // Classe Estudante que herda da classe Pessoa
    {
        public string Curso { get; set; } // Propriedade pública para armazenar o curso do estudante

        // Construtor da classe Estudante
        public Estudante(string nome, int idade, string curso) : base(nome, idade) // Chama o construtor da classe base (Pessoa)
        {
            Curso = curso; // Inicializa o curso do estudante com o valor passado como argumento
        }

        // Método público para exibir informações do estudante, incluindo as informações da pessoa (nome e idade)
        public void ExibirInformacoes() // Método público para exibir informações do estudante
        {
            Console.WriteLine("Nome: " + Nome); // Exibe o nome da pessoa (herdado da classe Pessoa)
            Console.WriteLine("Idade: " + Idade); // Exibe a idade da pessoa (herdado da classe Pessoa)
            Console.WriteLine("Curso: " + Curso); // Exibe o curso do estudante
        }
    }

}
