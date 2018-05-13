using System;


namespace Divisao
{
   public class Divisao
    {

        static void Main() { }
        public void Divide()
        {
            Console.WriteLine("Essa aplicação calcula a divisão de dois numeros");
            Console.WriteLine("Digite o primeiro numero:");
            int numeroUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int numeroDois = int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da Divisão de " + numeroUm + " / " + numeroDois + " é : " + numeroUm / numeroDois + " !");

            
        }
    }
}
