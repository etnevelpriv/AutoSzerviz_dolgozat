namespace AutoSzerviz_dolgozat
{
    public class TeherAuto : Jarmu
    {
        private int rakomany;
        public int Rakomany
        {
            get
            {
                return rakomany;
            }
            set
            {
                if (value < 0)
                {
                    rakomany = 0;
                } else if (value > 20)
                {
                    rakomany = 20;
                } else
                {
                    rakomany = value;
                }
            }
        }
        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Rakomany = rakomany;
        }
        public override string InformaciotAd()
        {
            return ($"{rendszam} - {kor} éves teherautó, {kilometerOra} km-rel, rakomány: {rakomany}% tonna.");
        }
        public override string Szervizel(int dij)
        {
            rakomany = 0;
            return (base.Szervizel(dij));
        }
    }
}