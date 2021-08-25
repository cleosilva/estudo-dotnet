using System;

namespace RolagemDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gerando 3 números aleatórios
            Random dice = new Random();

            int roll1 = dice.Next(1,7);
            int roll2 = dice.Next(1,7);
            int roll3 = dice.Next(1,7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            // Regra do jogo usando condicionais

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("Rolagem triplicada! +6 bonus no total.");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("Rolagem dobrada! +2 bonus no total.");
                    total += 2;
                }
            }


            if (total >= 16)
            {
                Console.WriteLine("Você ganhou um carro!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("Você ganhou um laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("Você ganhou uma viagem!");
            }
            else
            {
                Console.WriteLine("Você ganhou um gatinho!");
            }
        }
    }
}
