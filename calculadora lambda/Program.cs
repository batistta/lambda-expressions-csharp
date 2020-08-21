using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0, num1 = 0, num2 = 0;
            do
            {
                Console.WriteLine("1 - Somar......:");
                Console.WriteLine("2 - Subtrair...:");
                Console.WriteLine("3 - Multiplicar:");
                Console.WriteLine("4 - Dividir....:");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite o primeiro numero:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero.:");
                num2 = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        Console.WriteLine("Soma = " + soma(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Subtracao = " + subt(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplicacao: " + mult(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Divisao: " + divi(num1, num2));
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
                Console.ReadKey();
                Console.Clear();
            } while (op != 0);
        }
        public static Func<int, int, int> soma = (x, y) => x + y;
        public static Func<int, int, int> subt = (x, y) => x - y;
        public static Func<int, int, int> mult = (x, y) => x * y;
        public static Func<int, int, int> divi = (x, y) => x / y;
    }
}
