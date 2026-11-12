using System;
using System.Collections.Generic;
using System.Text;

namespace MuholdApp
{
    public class KutatasiMuhold : Muhold
    {
        public int MuszerekSzama { get; set; }
        public KutatasiMuhold(string azonosito, int sulykg, int muszerekszama) : base(azonosito, sulykg)
        {
            MuszerekSzama = muszerekszama;
        }
        public override int NapiKoltseg()
        {
            return base.NapiKoltseg() + MuszerekSzama * 200;
        }
        public override string ToString()
        {
            return $"{base.ToString()} | Műszerek:{MuszerekSzama} db";
        }
    }
}
