// See https://aka.ms/new-console-template for more information
using System;

class Hello
{
    static void Main()
    {
        int i; int j, vtab = 0, vtab1 = 0;
        Console.WriteLine("saisir la longeur du tableau");
        vtab = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("saisir");
        vtab1 = Convert.ToInt32(Console.ReadLine());
        int[,] tab = new int[vtab, vtab1];
        for (i = 0; i < tab.GetLength(0); i++)
        {
            for (j = 0; j < tab.GetLength(1); j++)
            {
                Console.WriteLine("saisir la " + (j + 1) + " valeur");
                tab[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("saisir la " + (i + 1) + " valeur");
            tab[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(tab[i+ , j]);
        }
            Console.WriteLine("|");

        static void ()
        {
            int Nbnotes = 0, moy = 0, cumul = 0, i = 0;
            Console.WriteLine("Combien de note voulez vous saisir");
            Nbnotes = Convert.ToInt32(Console.ReadLine());
            int[,] = new int[tab];
        }
        }
}