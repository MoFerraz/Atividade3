using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar o valor do produto

            Console.WriteLine("Por favor, informe o valor do produto ");

            decimal valorProduto = decimal.Parse(Console.ReadLine());

            // Solicitar a porcentagem de desconto para o produto

            Console.WriteLine("Agora, informe a porcentagem do desconto ");

            decimal desconto = decimal.Parse(Console.ReadLine());

            // Fazer as condições if else

            if ( desconto > 50 && desconto < 0)
            {
                Console.WriteLine(" A taxa de desconto tem que estar entre 0 e 50%");

                Console.ReadKey();
                Environment.Exit(0);
            }

            else if (valorProduto < 100 && desconto > 10)

        }
    }
}
