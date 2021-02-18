using System;
using System.Collections.Generic;

namespace CHARP_Listes_Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuer = "o";
            int input0 = 1;

            List<int> numbers = new List<int>();

            Console.WriteLine("Utilisateur, veuillez indiquer un nombre à multiplier.");
            int input1 = int.Parse(Console.ReadLine());
            numbers.Add(input1);

            while (continuer == "o")
            {
                Console.WriteLine("\nSouhaitez-vous y multiplier un autre nombre ? O/N");
                continuer = Console.ReadLine().ToLower();

                if (continuer == "o")
                {
                    Console.WriteLine("Alors veuillez indiquer un autre nombre.");
                    int input2 = int.Parse(Console.ReadLine());
                    numbers.Add(input2);
                }
                else
                {
                    Console.WriteLine("\nles nombres multipliés sont :");
                    foreach (int value in numbers)
                    {
                        Console.WriteLine($"{value}");
                     input0 *= value;}
                     Console.WriteLine($"Le résultat est {input0}");
                    
                }

            }
            }

            

        }
    }


/*
 À l’aide d’une boucle, demander à l’utilisateur les nombres qu’il souhaite multiplier. Les stocker dans une liste.
Calculer le résultat de la multiplication et l’afficher en rappelant tous les nombres.
*/