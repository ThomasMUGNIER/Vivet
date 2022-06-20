using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Library.B;
using Library.A;

namespace Library.A
{
    public class cls_ID:Object
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
            NumObjt++;
            return NumObjt;
        }

        public int ID
        {
            get { return c_ID; }
        }

    }
}
