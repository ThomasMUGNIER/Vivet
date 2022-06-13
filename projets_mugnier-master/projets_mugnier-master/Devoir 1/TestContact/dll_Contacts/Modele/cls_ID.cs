using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using dll_Contacts.Modele;
using dll_Contacts.DAO;

namespace dll_Contacts.Modele
{
    public class cls_ID
    {
        private int c_ID;
        static int NumObjt = 0;
        ~cls_ID()
        {
            NumObjt--;
        }

        public cls_ID(int pID)
        {
            c_ID = pID;
            NumObjt++;
        }

        public static int NouvelID()
        {
            return NumObjt + 1;
        }

        public int ID
        {
            get { return c_ID; }
        }

    }
}
