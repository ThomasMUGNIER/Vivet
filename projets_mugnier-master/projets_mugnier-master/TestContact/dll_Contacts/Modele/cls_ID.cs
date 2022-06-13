using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Contacts
{
    public class cls_ID:Object 
    {
        private int c_ID;
        static int s_NbObjets = 0;

        static cls_ID()
        {
            s_NbObjets = 0;
        }

        ~cls_ID()
        {
            s_NbObjets--;
        }

        public cls_ID(int pID)
        {
            c_ID = pID;
            s_NbObjets++;
        }

        public static int NouvelID()
        {
            return s_NbObjets + 1;
        }

        public int ID
        {
            get { return c_ID; }
        }

    }
}
