using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
