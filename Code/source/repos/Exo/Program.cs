using System;
using System.Diagnostics.Eventing.Reader;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {



            Exercice12bis();




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

            static int Saisie(Console.ReadLine())
            {
                Console.WriteLine("Veuillez Saisir un nombre");
                return (int.Parse(Console.ReadLine()));

            }


            static void Exercice12bis()
            {
                int Multi;
                int Nombre = Saisie();
                Console.WriteLine($"table de {Nombre}");
                for (int i = 0; i < 11; i++)
                {
                    Multi = Nombre * i;
                    Console.WriteLine($"{Nombre} x {i} = {Multi}");

                }
            }
        }
    }
}
