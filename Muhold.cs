using System;
using System.Collections.Generic;
using System.Text;

namespace MuholdApp
{
    public class Muhold
    {
        public string Azonosito { get; set; }
        protected int sulyKg;
        public int SulyKg 
        {
            get
            {
                return sulyKg;
            }
            set
            {
                if (value <= 0)
                {
                    value = 100;
                }
            }
        }
        private static int osszesMuholdSzama;
        public static int OsszesMuholdSzama { get { return osszesMuholdSzama; } }

        public Muhold (string azonosito, int sulykg)
        {
            Azonosito = azonosito;
            SulyKg = sulykg;
            osszesMuholdSzama++;
        }
        public virtual int NapiKoltseg()
        {
            return SulyKg * 5;
        }
        public override string ToString()
        {
            return $"Műhold{Azonosito} | Tömeg: {SulyKg} kg | Napi költség: {NapiKoltseg()} EUR";
        }
    }
}
