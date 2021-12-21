using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmoteka
{
    class GlobalClass
    {
        private static string v_Variant1 = "";
        public static string Variant1 { get { return v_Variant1; } set { v_Variant1 = value; } }

        private static string v_Variant2 = "";
        public static string Variant2 { get { return v_Variant2; } set { v_Variant2 = value; } }

        private static string v_Variant3 = "";
        public static string Variant3 { get { return v_Variant3; } set { v_Variant3 = value; } }

        private static string v_Variant4 = "";
        public static string Variant4 { get { return v_Variant4; } set { v_Variant4 = value; } }
    }
}
