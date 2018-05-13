using System;


namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma.Soma somatorio = new Soma.Soma();
            Divisao.Divisao divisao = new Divisao.Divisao();
            Multiplicação.Multiplicacao multiplica = new Multiplicação.Multiplicacao();
            Subtracao.Subtracao subtrai = new Subtracao.Subtracao();

            somatorio.Some();
            divisao.Divide();
            multiplica.Multiplica();
            subtrai.Diminui();
            Console.ReadKey();         
            
        }
    }
}
