using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.B;
using Library.A;
using Npgsql;

namespace Library.B
{
    public class cls_DAO_Entreprise_BD : Cls_DAO_Entreprise
    {
        /// <summary>
        /// Permet d'instancier les objets
        /// </summary>
        /// <returns></returns>
        public override Dictionary<int, cls_entreprise> cree_entreprise()
        {
            Dictionary<int, cls_entreprise> l_dic_entreprise = new();

            for (int i = 0; i < 50; i++)
            {
                l_dic_entreprise.Add((i + 1), new cls_entreprise((i + 1), "Raison sociale " + (i + 1), codepostalealeatoire(), "Commune " + (i + 1), "mail." + (i + 1) + "@gmail.com", "www.URL" + (i + 1) + ".fr"));
            }

            return l_dic_entreprise;
        }

        /// <summary>
        /// Enregistrer le tableau des entreprises en CSV
        /// </summary>
        /// <param name="p_list_entreprise"></param>
        public override void save_entreprise_CSV(List<cls_entreprise> p_list_entreprise)
        {
            StreamWriter l_StreamWritter = new("Entreprises.csv");

            foreach (cls_entreprise l_element in p_list_entreprise)
            {
                l_StreamWritter.WriteLine(l_element.ID + ";" + l_element.Raisonsociale + ";" + l_element.Codepostale + ";" + l_element.Commune + ";" + l_element.mail + ";" + l_element.URL);
            }
            l_StreamWritter.Close();
        }

        /// <summary>
        /// Enregistrer une entreprise au format CSV
        /// </summary>
        /// <param name="p_chaine_CSV">Chaine au format CSV permettant d'initialiser l'objet entreprise</param>
        public override cls_entreprise crea_entreprise(string p_chaine_CSV)
        {
            string[] l_tabInfosSTR = p_chaine_CSV.Split(';');
            int ID = int.Parse(l_tabInfosSTR[0]);
            string raisonsociale = l_tabInfosSTR[1];
            string codepostale = l_tabInfosSTR[2];
            string Commune = l_tabInfosSTR[3];
            string mail = l_tabInfosSTR[4];
            string URL = l_tabInfosSTR[5];

            return new cls_entreprise(ID, raisonsociale, codepostale, Commune, mail, URL);
        }

        /// <summary>
        /// Lit les CSV des entreprises et de les transformer en objet
        /// </summary>
        public override Dictionary<int, cls_entreprise> lire_entreprise_CSV()
        {
            Dictionary<int, cls_entreprise> l_dicEntreprise = new Dictionary<int, cls_entreprise>();
            NpgsqlCommand l_cmd = new NpgsqlCommand("SELECT ID,raison_sociale,code_postal,commune,mail,URL FROM entreprise", cls_DAO_BD.Connexion);
            NpgsqlDataReader l_reader = l_cmd.ExecuteReader();
            while (l_reader.Read())
            {
                int l_ID = l_reader.GetInt32(0);
                string l_Raisonsociale = l_reader.GetString(1);
                string l_codepostale = l_reader.GetString(2);
                string l_commune = l_reader.GetString(3);
                string l_mail = l_reader.GetString(4);
                string l_URL = l_reader.GetString(5);
                l_dicEntreprise.Add(l_ID, new cls_entreprise(l_ID, l_Raisonsociale,l_codepostale,l_mail,l_commune,l_URL, l_reader.GetValue(2) is DBNull ? null : l_reader.GetString(2)));
            }
            l_reader.Close();
            l_reader = null;
            return l_dicEntreprise;
        }

    }
}
