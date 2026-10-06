using System;

namespace AutoSzerviz_dolgozat;

public class SportAuto : Jarmu
{
    private int loero;
    public int Loero
    {
        get
        {
            return loero;
        }
        set
        {
            if (value < 500)
            {
                loero = 500;
            }
            else if (value > 1500)
            {
                loero = 1500;
            }
            else
            {
                loero = value;
            }
        }
    }
    public SportAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int loero) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
    {
        Loero = loero;
    }
    public override void InformaciotAd()
    {
        Console.WriteLine($"{rendszam} - {kor} éves sport autó, {kilometerOra} km-rel, {loero} lóerővel.");
        return;
    }
    public override void Szervizel(int dij)
    {
        Loero = loero + 50;
        base.Szervizel(dij);
    }


}
