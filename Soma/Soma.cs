using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    public class Soma
    {
        static void Main(string[] args)
        {
        }

        public void Some()
        {
            Console.WriteLine("Essa aplicação calcula a adição de dois numeros");
            Console.WriteLine("Digite o primeiro numero:");
            int numeroUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int numeroDois = int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da adição de " +  numeroUm + "+ " + numeroDois + "é : "+ numeroUm + numeroDois + " !");

            Console.ReadKey();
        }
    }
}
