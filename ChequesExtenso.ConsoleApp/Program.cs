using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChequesExtenso.ConsoleApp.Tela;

namespace ChequesExtenso.ConsoleApp
{
    class Program
    {
        const int CAPACIDADE_NUMEROS = 100;

        static void Main(string[] args)
        {
            TelaBase telaBase = new TelaBase();

            Console.Clear();

            while (true)
            {

                TelaBase tela = (TelaBase)telaBase.ObterTela();


                if (tela == null)
                {
                    break;
                }

                string opcao = tela.ObterOpcao();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    continue;

                Console.Clear();

                if (opcao == "1")
                    tela.VisualizarExtenso();

                Console.Clear();
            }
        }
    }
}



