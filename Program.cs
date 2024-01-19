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
            // Solicitar senha para acesso ao software

            string senha = "crocodiloamarelo";
            Console.WriteLine("Digite a senha, por favor");

            if (Console.ReadLine() != senha)
            {
                Console.WriteLine("Senha incorreta ");

                Console.ReadKey();
                Environment.Exit(0);
            }
             
            // Limpar a tela
            Console.Clear();

            // Solicitar o valor do produto
            Console.WriteLine("Por favor, informe o valor do produto ");
            decimal valorProduto = decimal.Parse(Console.ReadLine());

            // Solicitar a porcentagem de desconto para o produto
            Console.WriteLine("Agora, informe a porcentagem do desconto ");
            decimal desconto = decimal.Parse(Console.ReadLine());
           
            // Fazer as condições if else

            if (desconto > 50 && desconto < 0)
            {
                Console.WriteLine(" A taxa de desconto tem que estar entre 0 e 50%");

                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (valorProduto < 100 && desconto > 10)
            {   
                Console.WriteLine(" O valor do desconto deve ser menor que 10%");

                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (valorProduto < 200 && desconto > 20)
            {
                Console.WriteLine(" O valor do desconto deve ser menor que 20%");

                Console.ReadKey();
                Environment.Exit(0);
            }

            // Mostrar o valor final, já com o desconto
            decimal porcentagem = desconto / 100;
            decimal resultado = valorProduto - (valorProduto * porcentagem);

            Console.WriteLine("Valor do produto: ");
            Console.WriteLine("R$ " + Math.Round(resultado, 2));
        }
    }
}
