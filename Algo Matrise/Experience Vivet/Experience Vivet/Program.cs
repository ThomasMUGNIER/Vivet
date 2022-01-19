using System;

class Hello
{
    static void Main()
    {
        int[] l_tab = new int[20];
        int[] l_tab2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for(int i=0; i<l_tab2.Length; i++)
        {
            Console.WriteLine("valeur saisir vite manger faim" + (i+1));       
            string l_tabsaisie = Console.ReadLine();
            int l_valeur = Convert.ToInt32(l_tabsaisie);
            l_tab2[i] = l_valeur;
        }
    }
}