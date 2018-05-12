using System;


namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma.Soma somatorio = new Soma.Soma();
            Divisao.Divisao divisao = new Divisao.Divisao();


            somatorio.Some();
            divisao.Divide();
            Console.ReadKey();

            
            
        }
    }
}
