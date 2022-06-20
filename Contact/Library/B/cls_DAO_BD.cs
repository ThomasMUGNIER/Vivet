using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Library.B
{
    public class cls_DAO_BD
    {
        private static NpgsqlConnection ConnexionBD;

        public static void Connecter()
        {
            ConnexionBD = new NpgsqlConnection();
            ConnexionBD.ConnectionString = "Server=127.0.0.1;Port=5432;Database=TP4;User Id=postgres;Password=Wardeathstrife0;";
            ConnexionBD.Open();
        }

        public static NpgsqlConnection Connexion
        {
            get { return ConnexionBD; }
        }

    }
}
