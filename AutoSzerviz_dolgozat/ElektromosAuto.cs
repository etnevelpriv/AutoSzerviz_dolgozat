namespace AutoSzerviz_dolgozat
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;
        public int AkkumulatorSzint
        {
            get
            {
                return akkumulatorSzint;
            }
            set
            {
                if (value < 0)
                {
                    akkumulatorSzint = 0;
                }
                else if (value > 100)
                {
                    akkumulatorSzint = 100;
                }
                else
                {
                    akkumulatorSzint = value;
                }
                ;
            }
        }
        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, 0)
        {
            AkkumulatorSzint = akkumulatorSzint;
        }
        public override string InformaciotAd()
        {
            return ($"{rendszam} - {kor} éves elektromos autó, {kilometerOra} km-rel, {akkumulatorSzint}% töltöttséggel.");
        }
        public override string Szervizel(int dij)
        {
            if (dij > 100000)
            {
                kilometerOra = kilometerOra - 10000;
            }
            akkumulatorSzint = akkumulatorSzint - 10;
            return ($"A jármű szervizelése megtörtént");
        }

    }
}