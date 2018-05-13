using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtracao
{
    public class Subtracao
    {
        static void Main(string[] args)
        {
        }

        public void Diminui()
        {
            Console.WriteLine("Essa aplicação calcula a subtração de dois numeros");
            Console.WriteLine("Digite o primeiro numero:");
            int numeroUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int numeroDois = int.Parse(Console.ReadLine());

            int resultado = numeroUm - numeroDois;

            Console.WriteLine("O resultado da subtração de " + numeroUm + " - " + numeroDois + " é : " + resultado + " !\n");
        }
    }
}
