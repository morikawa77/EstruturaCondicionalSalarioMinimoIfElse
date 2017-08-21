using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCondicionalSalarioMinimoIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario;

            Console.Write("Digite seu salário: ");

            salario = Convert.ToDecimal(Console.ReadLine());

            if (salario > 937m)

            {

                Console.Write("Seu salário é maior que o salário mínimo.");

            } else
            {
                Console.Write("Seu salário é menor que o salário mínimo.");
            }

            Console.ReadLine();
        }
    }
}
