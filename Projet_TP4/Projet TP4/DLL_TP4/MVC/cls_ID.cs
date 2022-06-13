namespace DLL
{
    public class Cls_ID
    {
        private readonly int c_ID;
        static int s_NbObjet = 0;

        /// <summary>
        /// Constructeur qui instancie le nombre d'objets
        /// </summary>
        static Cls_ID()
        {
            s_NbObjet = 0;
        }

        /// <summary>
        /// Destructeur qui décrémente le nombre d'objets
        /// </summary>
        ~Cls_ID()
        {
            s_NbObjet--;
        }

        /// <summary>
        /// Constructeur qui permet d'initialiser un ID
        /// </summary>
        /// <param name="pID"></param>
        public Cls_ID(int pID)
        {
            c_ID = pID;
            s_NbObjet++;
        }

        /// <summary>
        /// Permet de renvoyer le prochain ID inutilisé
        /// </summary>
        /// <returns></returns>
        public static int NouvelID()
        {
            return s_NbObjet + 1;
        }

        /// <summary>
        /// Permet de définir l'ID
        /// </summary>
        public int ID
        {
            get 
            { 
                return c_ID;
            }
        }
    }
}
