using System;
using System.Text.RegularExpressions;

namespace Urbiautos
{
    public class CustomTools
    {
        public static String OnlyNum(String Numeros)
        {
            Regex rgx = new Regex("[^0-9]");
            String NumRgx = rgx.Replace(Numeros, "");
            return NumRgx;
        }
        public static String OnlyNumK(String Rut)
        {
            Regex rgx = new Regex("[^K|k0-9]");
            String RutRgx = rgx.Replace(Rut, "");
            return RutRgx;
        }
        public static String formatoRut(String Rut)
        {
            Rut = OnlyNumK(Rut);
            String RutF = Rut;
            if (Rut.Length > 1)
            {
                RutF = Rut.Substring(0, Rut.Length - 1) + "-" + Rut[Rut.Length - 1];
            }
            return RutF;
        }
        public static int OnlyNumInt(String Numeros)
        {
            Regex rgx = new Regex("[^0-9]");
            String NumRgx = rgx.Replace(Numeros, "");
            int total = 0;
            if (!NumRgx.Equals(""))
            {
                total = Int32.Parse(NumRgx);
            }
            return total;
        }
        public static String OnlyChars(String PatenteTxb)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            String PatenteRgx = rgx.Replace(PatenteTxb, "");
            return PatenteRgx;
        }
    }
}
