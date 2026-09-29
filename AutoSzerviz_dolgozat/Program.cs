
namespace AutoSzerviz_dolgozat
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Szerviz szerviz = new Szerviz();
            Jarmu ujAuto = new Jarmu("rmb-345", 12, 199999, 80);
            ujAuto.InformaciotAd();
            ujAuto.Szervizel(9999);
            ujAuto.Szervizel(1000000);
            ujAuto.InformaciotAd();

            ElektromosAuto ujElektromosAuto = new ElektromosAuto("ELEKTROMOS", 100, 250000, 120);
            ujElektromosAuto.InformaciotAd();

            TeherAuto ujTeher = new TeherAuto("TEHER", 10, 25000, 70, 30);
            ujTeher.InformaciotAd();
            ujTeher.Szervizel(9999);
            ujTeher.InformaciotAd();

            Szerviz szerviz = new Szerviz();
            szerviz.JarmuFelvetel(ujAuto);
            szerviz.JarmuFelvetel(ujElektromosAuto);
            szerviz.JarmuFelvetel(ujTeher);
            szerviz.CsoportSzerviz(10000);
            szerviz.InformaciokListazasa();
        }
    }
}