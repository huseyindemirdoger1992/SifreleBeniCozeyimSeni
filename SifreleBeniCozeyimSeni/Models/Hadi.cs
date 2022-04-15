using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreleBeniCozeyimSeni.Models
{
    public class Hadi
    {
        public string Sifrele(string Deger)
        {
            string Sonuc = null;
            char[] _Deger = Deger.ToCharArray();
            foreach (char tane in _Deger)
            {
                Sonuc += Convert.ToChar(tane - 8).ToString();
            }
            return Sonuc;
        }
        public string Cozumle(string SifrelenmisDeger)
        {
            string deger = null;
            char[] _SifrelenmisDeger = SifrelenmisDeger.ToCharArray();
            foreach (char tane in _SifrelenmisDeger)
            {
                deger += Convert.ToChar(tane + 8).ToString();
            }
            return deger;
        }
    }
}
