using System.Dynamic;

namespace AutoSzerviz_dolgozat
{
    public class Jarmu
    {
        protected string rendszam = "ISMERETLEN";
        protected int kor;
        protected int kilometerOra;
        private int uzemanyagSzint;
        private bool szervizSzukseges;

        public string Rendszam
        {
            get
            {
                return rendszam;
            }
            set
            {
                if (value != null && value != "")
                {
                    rendszam = value;
                }
                else
                {
                    rendszam = "ISMERETLEN";
                }
            }
        }
        public int Kor
        {
            get
            {
                return kor;
            }
            set
            {
                if (value < 0)
                {
                    kor = 0;
                }
                else if (value > 50)
                {
                    kor = 50;
                }
                else
                {
                    kor = value;
                };
            }
        }
        public int KilometerOra
        {
            get
            {
                return kilometerOra;
            }
            set
            {
                if (value < 0)
                {
                    kilometerOra = 0;
                } else
                {
                    kilometerOra = value;
                }
            }
        }
        public int UzemanyagSzint
        {
            get
            {
                return uzemanyagSzint;
            }
            set
            {
                if (value < 0)
                {
                    uzemanyagSzint = 0;
                }
                else if (value > 100)
                {
                    uzemanyagSzint = 100;
                }
                else
                {
                    uzemanyagSzint = value;
                };
            }
        }
        public bool SzervizSzukseges
        {
            get
            {
                return kilometerOra>=200000;
            }
        }
        public Jarmu (string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
        }
        public virtual string InformaciotAd()
        {
            return ($"{rendszam} - {kor} éves jármű, {kilometerOra} km-rel");
        }
        public virtual string Szervizel(int dij)
        {
            if (dij > 100000)
            {
                kilometerOra = kilometerOra-10000;
            }
            uzemanyagSzint = uzemanyagSzint-10;
            return ($"A jármű szervizelése megtörtént");
        }
    }
}