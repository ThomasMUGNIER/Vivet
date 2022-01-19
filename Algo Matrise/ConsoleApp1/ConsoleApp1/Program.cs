using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MoyenneTab
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, b;
            int[,] tab = new int[];
            for (i = 0; i < tab.GetLength(0); i++)
            {
                for (b = 0; b < tab.GetLength(1); b++)
                {
                    Console.WriteLine("Saisir coef de la ligne " + (i + 1) + " et de la colonne " + (b + 1));
        
                    tab[i, b] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < tab.GetLength(0); i++)
            {
                for (b = 0; b < tab.GetLength(1); b++)
                {
                    Console.Write(tab[i, b]);
                }
            }Console.WriteLine(); Console.Read();  
        }
    }
}