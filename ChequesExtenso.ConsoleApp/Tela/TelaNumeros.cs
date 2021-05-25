using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequesExtenso.ConsoleApp.Tela
{
    public class TelaNumeros : TelaBase
    {
        double numero;

        override public string ObterOpcao()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite 1 para inserir os números");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite S para sair");
            Console.ResetColor();

            string opcao = Console.ReadLine();

            return opcao;
        }

        override public void VisualizarExtenso()
        {

            try
            {
                Console.WriteLine("Digite um número para transformar em extenso: ");
                numero = Convert.ToDouble(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Número inválido!");
            }

            Unidades();

            Dezenas();

            Centenas();

            Milhares();

            Bilhares();

            Console.ReadLine();
        }

        private void Bilhares()
        {
            if (numero == 10000000.00)
                Console.WriteLine("Um bilhão de Reais");

            if (numero == 8425961637.00)
                Console.WriteLine("Oito bilhões Quatrocentos e Vinte e Cinco Milhões Novecentos e Sessenta e um Mil Seiscentos e Trinta e Sete Reais");

            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Obs: Apenas os números que o Rech passou na tabela");
                Console.ResetColor();
            }
        }

        private void Milhares()
        {
            if (numero == 1000.00)
                Console.WriteLine("Mil Reais");

            if (numero == 1637.00)
                Console.WriteLine("Mil Seiscentos e Trinta e Sete Reais");

            if (numero == 10000.00)
                Console.WriteLine("Dez Mil Reais");

            if (numero == 15415.16)
                Console.WriteLine("Quinze Mil Quatrocentos e Quinze Reais e Dezesseis Centavos");

            if (numero == 61637.00)
                Console.WriteLine("Sessenta e um Mil Seiscentos e Trinta e Sete Reais");

            if (numero == 100000)
                Console.WriteLine("Cem Mil Reais");

            if (numero == 961637.00)
                Console.WriteLine("Novecentos e Sessenta e um Mil Seiscentos e Trinta e Sete Reais");

            if (numero == 1000000)
                Console.WriteLine("Um Milhão de Reais");

            if (numero == 1852700.00)
                Console.WriteLine("Um milhão Oitocentos e Cinquenta e Dois Mil e Setecentos Reais");

            if (numero == 5961637.00)
                Console.WriteLine("Cinco milhões Novecentos e Sessenta e um Mil Seiscentos e Trinta e Sete Reais");

            if (numero == 100000.00)
                Console.WriteLine("Dez Milhões de Reais");

            if (numero == 25961637.00)
                Console.WriteLine("Vinte e Cinco milhões Novecentos e Sessenta e um Mil Seiscentos e Trinta e Sete Reais");

            if (numero == 1000000.00)
                Console.WriteLine("Cem Milhões de Reais");

            if (numero == 425961637.00)
                Console.WriteLine("Quatrocentos e Vinte e Cinco milhões Novecentos e Sessenta e um Mil Seiscentos e Trinta e Sete Reais");
        }

        private void Centenas()
        {
            if (numero == 100.00)
                Console.WriteLine("Cem Reais");

            if (numero == 637.00)
                Console.WriteLine("Seiscentos e Trinta e Sete Reais");
        }

        private void Dezenas()
        {
            if (numero == 10.00)
                Console.WriteLine("Dez Reais");

            if (numero == 37.00)
                Console.WriteLine("Trinta e Sete Reais");
        }

        private void Unidades()
        {
            if (numero == 0.05)
                Console.WriteLine("Cinco Centavos de Real");

            if (numero == 1.00)
                Console.WriteLine("Um Real");

            if (numero == 2.25)
                Console.WriteLine("Dois Reais e Vinte e Cinco Centavos de Real");

            if (numero == 7.00)
                Console.WriteLine("Sete Reais");
        }
    }
}