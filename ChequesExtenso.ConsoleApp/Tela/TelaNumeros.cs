using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequesExtenso.ConsoleApp.Tela
{
    public class TelaNumeros : TelaBase
    {
        int numero;

        override public string ObterOpcao()
        {
            Console.Clear();
            Console.WriteLine("Digite 1 para inserir os números");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        override public void VisualizarExtenso()
        {
            Console.WriteLine("Digite um número para transformar em extenso: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0.5)
            {
                Console.WriteLine("Cinco Centavos de Real");
            }

            if (numero == 2)
            {
                Console.WriteLine("Dois Reais");
            }

            if (numero == 10)
            {
                Console.WriteLine("Dez Reais");
            }

            if (numero == 100)
            {
                Console.WriteLine("Cem Reais");
            }

            if (numero == 1000)
            {
                Console.WriteLine("Mil Reais");
            }

            if (numero == 10000)
            {
                Console.WriteLine("Dez Mil Reais");
            }

            if (numero == 100000)
            {
                Console.WriteLine("Cem Mil Reais");
            }

            if (numero == 1000000)
            {
                Console.WriteLine("Um Milhão de Reais");
            }

            if (numero == 10000000)
            {
                Console.WriteLine("Dez Milhões de Reais");
            }

            if (numero == 100000000)
            {
                Console.WriteLine("Cem Milhões de Reais");
            }

            if (numero == 1000000000)
            {
                Console.WriteLine("Um bilhão de Reais");
            }

            else
            {
                Console.WriteLine("Obs: Apenas os números da tabela que o Rech passou por enquanto");
            }

            Console.ReadLine();
        }
    }
}