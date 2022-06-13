using System;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace x
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("Choisir un exercise entre 1 et 12 écrire le nombre");
            Console.WriteLine("Exercise 1");
            Console.WriteLine("Exercise 2");
            Console.WriteLine("Exercise 3");
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Exercise 5");
            Console.WriteLine("Exercise 6");
            Console.WriteLine("Exercise 7");
            Console.WriteLine("Exercise 8");
            Console.WriteLine("Exercise 9");
            Console.WriteLine("Exercise 10");
            Console.WriteLine("Exercise 11");
            Console.WriteLine("Exercise 12");
            Console.WriteLine("Exercise 13");
            Console.WriteLine("Exercise 14");
            Console.WriteLine("Exercise 15");
            Console.WriteLine("Exercise 16");
            Console.WriteLine("Exercise 17");
            Console.WriteLine("Exercise 18");
            Console.WriteLine("Exercise 19");
            Console.WriteLine("Exercise 20");
            Console.WriteLine("Exercise 21");
            Console.WriteLine("Exercise 22");


            Console.WriteLine();

            Console.Write("Choisis ");


            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Exercice1();
                    Thread.Sleep(2000);

                    break;
                case "2":
                    Console.Clear();
                    Exercice2();
                    Thread.Sleep(2000);

                    break;
                case "3":
                    Console.Clear();
                    Exercice3();
                    Thread.Sleep(2000);

                    break;
                case "4":
                    Console.Clear();
                    Exercice4();
                    Thread.Sleep(2000);

                    break;
                case "5":
                    Console.Clear();
                    Exercice5();
                    Thread.Sleep(2000);

                    break;
                case "6":
                    Console.Clear();
                    Exercice6();
                    Thread.Sleep(2000);

                    break;
                case "7":
                    Console.Clear();
                    Exercice7();
                    Thread.Sleep(2000);

                    break;
                case "8":
                    Console.Clear();
                    Exercice8();
                    Thread.Sleep(2000);

                    break;
                case "9":
                    Console.Clear();
                    Exercice9();
                    Thread.Sleep(2000);

                    break;
                case "10":
                    Console.Clear();
                    Exercice10();
                    Thread.Sleep(2000);

                    break;
                case "11":
                    Console.Clear();
                    Exercice11();
                    Thread.Sleep(2000);

                    break;
                case "12":
                    Console.Clear();
                    Exercice12();
                    Thread.Sleep(2000);

                    break;
                case "13":
                    Console.Clear();
                    Exercice13();
                    Thread.Sleep(2000);

                    break;
                case "14":
                    Console.Clear();
                    Exercice14();
                    Thread.Sleep(2000);

                    break;
                case "15":
                    Console.Clear();
                    Exercice15();
                    Thread.Sleep(2000);

                    break;
                case "16":
                    Console.Clear();
                    Exercice16();
                    Thread.Sleep(2000);

                    break;
                case "17":
                    Console.Clear();
                    Thread.Sleep(2000);

                    break;
                case "18":
                    Console.Clear();
                    Thread.Sleep(2000);

                    break;
                case "19":
                    Console.Clear();
                    Thread.Sleep(2000);

                    break;
                case "20":
                    Console.Clear();
                    Thread.Sleep(2000);

                    break;
                case "21":
                    Console.Clear();
                    Thread.Sleep(2000);

                    break;




            }
            static void Exercice1()
            {
                int VariableA = 1;
                int VariableB = VariableA + 3;
                VariableA = 3;
                Console.Write($" VariableA = {VariableA} et Variableb = {VariableB}");
            }

            static void Exercice2()
            {
                int VariableA = 5;
                int VariableB = 3;
                int VariableC = VariableA + VariableB;
                VariableA = 2;
                VariableC = VariableB - VariableA;
                Console.Write($" VariableA = {VariableA}  VariableB = {VariableB} et VariableC = {VariableC}");
            }

            static void Exercice3()
            {
                int VariableA = 5;
                int VariableB = 10;
                int Variabletempo = VariableB;
                VariableB = VariableA;
                VariableA = Variabletempo;
                Console.Write($" VariableA = {VariableA}  VariableB = {VariableB}");
            }

            static void Exercice4()
            {
                int Val = 231;
                int Double = Val * 2;
                Console.Write($" Val = {Val} et Double ={Double}");
            }


            static void Exercice5()
            {
                int nombre;
                Console.WriteLine("Entrez un nombre pour a mettre au carré : ");
                nombre = (int.Parse(Console.ReadLine())); // Fonction pour convertir une chaine de caractère en un INT
                nombre = nombre * nombre;
                Console.Write($"Voici votre nombre au carré {nombre}");
            }

            static void Exercice6()
            {
                int nombre;
                Console.WriteLine("Saisir votre nombre pour savoir si il est positif ou négatif");
                nombre = (int.Parse(Console.ReadLine()));
                if (nombre == 0)
                {
                    Console.WriteLine("Vous avez écrit 0 ");


                }
                else
                {
                    if (nombre > 0)
                    {
                        Console.WriteLine("Votre nombre est positif ");
                    }
                    else
                    {
                        Console.WriteLine("Votre nombre est négatif  ");
                    }

                }
            }

            static void Exercice7()
            {
                int NombreA, NombreB, NombreC;
                Console.WriteLine("Veuiller donner 3 nombre on je vous dirias si c'est positif");
                NombreA = (int.Parse(Console.ReadLine()));
                NombreB = (int.Parse(Console.ReadLine()));
                NombreC = (int.Parse(Console.ReadLine()));
                if (NombreA < NombreB)
                {
                    if (NombreB < NombreC)
                    {
                        Console.WriteLine("Vos nombres sont bien croissant");
                    }
                    else
                    {
                        Console.WriteLine("Vos nombres ne sont pas croissant");
                    }
                }
                else
                {
                    Console.WriteLine("Vos nombres ne sont pas croissant");
                }
            }

            static void Exercice8()
            {
                int Heures;
                int Minutes;
                Console.WriteLine("Veuillez saisir une heure valide ");
                Heures = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Veuillez saisir les minutes");
                Minutes = (int.Parse(Console.ReadLine()));
                Minutes = Minutes + 1;
                if (Minutes == 60)
                {
                    Heures = Heures + 1;
                    Minutes = 0;
                }
                Console.WriteLine($"Votre temps + 1min = {Heures}h et {Minutes}minutes");

            }

            static void Exercice9()
            {
                int Nombre;
                Console.WriteLine("Veuillez Saisir un nombre");
                Nombre = (int.Parse(Console.ReadLine()));
                while (Nombre > 3 || Nombre < 1)
                {

                    Console.WriteLine("Veuillez recommencer");
                    Nombre = (int.Parse(Console.ReadLine()));

                }
                Console.WriteLine("Bien Jouer");

            }

            static void Exercice10()
            {


                int Nombre;
                Console.WriteLine("Veuillez Saisir un nombre");
                Nombre = (int.Parse(Console.ReadLine()));
                while (Nombre > 20 || Nombre < 10)
                {
                    if (Nombre > 20)
                    {
                        Console.WriteLine("Plus petit");
                        Nombre = (int.Parse(Console.ReadLine()));

                    }
                    else
                    {
                        Console.WriteLine("Plus grand");
                        Nombre = (int.Parse(Console.ReadLine()));
                    }


                }
                Console.WriteLine("Bien Jouer");


            }
            static void Exercice11()
            {
                int Nombre;

                Console.WriteLine("Veuillez Saisir un nombre");
                Nombre = (int.Parse(Console.ReadLine()));
                for (int i = 0; i < 9; i++)
                {
                    Nombre = Nombre + 1;
                    Console.WriteLine($"{Nombre}");

                }


            }

            static void Exercice12()
            {


                int Nombre, Multi;

                Console.WriteLine("Veuillez Saisir un nombre");
                Nombre = (int.Parse(Console.ReadLine()));
                Console.WriteLine($"table de {Nombre}");
                for (int i = 0; i < 11; i++)
                {
                    Multi = Nombre * i;
                    Console.WriteLine($"{Nombre} x {i} = {Multi}");


                }
            }

            static void Exercice13()
            {
                int[] Tab = new int[4];
                for (int i = 0; i < Tab.Length; i++)
                {
                    Console.WriteLine("Saisir la " + (i + 1) + "ième valeur.");
                    Tab[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            static void Exercice14()
            {
                double[] Tab = new double[5];
                for (int i = 0; i < Tab.Length; i++)
                {
                    Console.WriteLine("Saisir la " + (i + 1) + "ième valeur.");
                    string Val = Console.ReadLine();
                    double Value = Convert.ToDouble(Val);
                    Tab[i] = Value;
                }
            }
            static void Exercice15()
            {
                double[] Tab = { 2, 3, 4, 5 };
                double L_moyenne = Moyenne(Tab);
                Console.WriteLine(L_moyenne);


            }
            static double Moyenne(double[] pTab)
            {
                double Cumul = 0;
                for (int i = 0; i < pTab.Length; i++)
                {
                    Cumul= Cumul + pTab[i];
                }
                return Cumul;  
            }
            static void Exercice16()
            {
                int[] tableau = new int[20];
                Random random = new Random();

                for (int i = 0; i < tableau.Length; i++)
                {
                    tableau[i] = random.Next();
                }
            }
            static double Exercice17(int[] tableau)
            {

                float Notes = 0;
                for (int i = 0; i < tableau.Length; i++)
                {
                    Notes += i;
                }

                float Moyenne = Notes / tableau.Length;
                return Moyenne;

            }
            static double Exercice18(int[] tableau)
            {
                int Mini = tableau[0];

                for (int i = 0; i < tableau.Length; i++)
                {
                    if (Mini > tableau[i])
                    {
                        Mini = tableau[i];
                    }
                }

                return Mini;

            }
            static double Exercice19(int[] tableau)
            {
                double Max = tableau[0];

                for (int i = 0; i < tableau.Length; i++)
                {
                    if (Max < tableau[i])
                    {
                        Max = tableau[i];
                    }
                }

                return Max;

            }

            static double Exercice20(int[] tableau, int indice)
            {
                for (int i = 0; i < tableau.Length; i++)
                {
                    if (tableau[i] == indice)
                    {
                        return i;
                    }
                }

                return -1;
            }

            static int[] Exercice21(int[] tableau)
            {

                bool Continue = true;

                while (Continue)
                {
                    Continue = false;

                    for (int i = 0; i < tableau.Length - 1; i++)
                    {

                        if (tableau[i] > tableau[i + 1])
                        {
                            Continue = true;
                            int temps = tableau[i];
                            tableau[i] = tableau[i + 1];
                            tableau[i + 1] = temps;

                        }


                    }
                }
                return tableau;
            }

        }
    }
}