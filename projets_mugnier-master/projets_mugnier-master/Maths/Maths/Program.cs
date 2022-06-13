using System;

namespace TriABulle
{
    public class TriABulle
    {
        static void Main(string[] args)
        {
            int taille;
            Console.WriteLine("Veuillez choisir la table de votre tableau");
            taille = Convert.ToInt32(Console.ReadLine());

            double[] Tab = new double[taille];
            int borne = Tab.Length;
            bool tri = false;

            for (int i = 0; i < Tab.Length; i++)
            {
                Console.WriteLine("Saisir la " + (i + 1) + "ième valeur.");
                Tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            while (tri == false)
            {
                tri = true;
                for (int j = 0; j < borne - 1; j++)
                {
                    if (Tab[j] > Tab[j + 1])
                    {
                        Echanger(Tab, j, j + 1);
                        tri = false;
                    }
                }
                borne = borne - 1;
            }

            for (int k = 0; k < Tab.Length; k++)
            {
                Console.WriteLine();
                Console.Write("|" + Tab[k] + "|");
            }
        }

        static void Echanger(double[] Tab, int Index1, int Index2)
        {
            double tmp;

            tmp = Tab[Index1];
            Tab[Index1] = Tab[Index2];
            Tab[Index2] = tmp;
        }
    }
}