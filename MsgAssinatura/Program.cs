using System;

namespace MsgAssinatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int diasExpiracao = random.Next(12);
            int descontoPorcentagem = 0;

            if(diasExpiracao == 0)
            {
                Console.WriteLine("Sua assinatura expirou!");
            }

            else if (diasExpiracao == 1)
            {
                Console.WriteLine("Sua assinatura expira em 1 dia.");
                descontoPorcentagem = 20;
            }
            else if (diasExpiracao <= 5 )
            {
                Console.WriteLine($"Sua assinatura expira em {diasExpiracao} dias.");
                descontoPorcentagem = 10;
            }
            else if (diasExpiracao <= 10)
            {
                Console.WriteLine("Sua assinatura irá expirar logo, renove agora!");
            } 
            if (descontoPorcentagem > 0)
            {
                Console.WriteLine($"Renove agora e ganhe {descontoPorcentagem}%.");
            }            
        }
    }
}
