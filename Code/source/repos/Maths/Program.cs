using System;
using Thread;

namespace Maths
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("Choisir un exercise entre 1 et 12 écrire le nombre"); 
            Console.WriteLine("Somme");
            Console.WriteLine("Moyenne");
            Console.WriteLine("Permutation");
            Console.WriteLine("Entier");

            Console.WriteLine();

            Console.Write("?????????????????????????????????????????????????? CHOISIS");


            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Somme();
                    Thread.Sleep(2000);

                    break;
                case "2":
                    Console.Clear();
                    Moyenne();
                    Thread.Sleep(2000);

                    break;
                case "3":
                    Console.Clear();
                    Permutation();
                    Thread.Sleep(2000);

                    break;
                case "4":
                    Console.Clear();
                    Entier();
                    Thread.Sleep(2000);

                    break;




            }
       
            static void Somme()
            {
                int A, B, result;
                A = 0;
                B = 0;
                result = 0;
                Console.WriteLine("Entée la valeur de A?");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entée la valeur de B?");
                B = Convert.ToInt32(Console.ReadLine());
                result = A + B;
                Console.Write("Valeur de la somme est : " + result + ".");
                Console.ReadLine();
            }

            static void Moyenne()
            {
                float A, B, moyenne;
                moyenne = 0;
                A = 0;
                B = 0;
                Console.WriteLine("Qu'elle est ta derniere note?");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qu'elle est ta deuxieme derniere note?");
                B = Convert.ToInt32(Console.ReadLine());
                moyenne = A + B ;
                moyenne = moyenne / 2;
                Console.Write("Valeur de la somme est : " + moyenne + ".");
                Console.ReadLine();

            }
            static void Permutation()
            {
                int A, B, temp;
                temp = 0;
                A = 0;
                B = 0;
                Console.WriteLine("Donner un entier de A?");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Donner un deuxieme entier de B?");
                B = Convert.ToInt32(Console.ReadLine());
                temp = B;
                B = A;
                A = temp;
                Console.Write("Valeur de B est : " + B + " et la valeur de A est : "+ A);
                Console.ReadLine();

            }
               static void Entier()
            {
                int A, B, C, D, resul;
                resul = 0;
                C = 0;
                D = 0;
                A = 0;
                B = 0;
                Console.WriteLine("Donner un entier de A?");
                A = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Donner un entier de B?");
                B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Donner un entier de C?");
                C = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Donner un entier de D?");
                D = Convert.ToInt32(Console.ReadLine());
                resul = C + D + A +B;
                resul = resul / 4;
                Console.Write("La moyenne des des 4 entiers demander est : " + resul );
                Console.ReadLine();
             }
        }
    }
}
