using System;


namespace Multiplicação
{
   public class Multiplicacao
    {
        static void Main(string[] args)
        {
        }

        public void Multiplica()
        {          
                Console.WriteLine("Essa aplicação calcula a multiplicação de dois numeros");
                Console.WriteLine("Digite o primeiro numero:");
                int numeroUm = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                int numeroDois = int.Parse(Console.ReadLine());

            int resultado = numeroUm * numeroDois;

                Console.WriteLine("O resultado da multiplicação de " + numeroUm + " x " + numeroDois + " é : " + resultado + " !" +"\n");
        }
    }
}
