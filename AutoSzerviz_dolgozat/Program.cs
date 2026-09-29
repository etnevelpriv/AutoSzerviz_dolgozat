
namespace AutoSzerviz_dolgozat
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Szerviz szerviz = new Szerviz();
            Jarmu ujAuto = new Jarmu("rmb-345", 12, 199999, 80);
            Console.WriteLine(ujAuto.InformaciotAd());
            Console.WriteLine(ujAuto.Szervizel(9999));
            Console.WriteLine(ujAuto.Szervizel(1000000));
            Console.WriteLine(ujAuto.InformaciotAd());

            ElektromosAuto ujElektromosAuto = new ElektromosAuto("ELEKTROMOS", 100, 250000, 120);
            Console.WriteLine(ujElektromosAuto.InformaciotAd());

            TeherAuto ujTeher = new TeherAuto("TEHER", 10, 25000, 70, 30);
            Console.WriteLine(ujTeher.InformaciotAd());
            Console.WriteLine(ujTeher.Szervizel(9999));
            Console.WriteLine(ujTeher.InformaciotAd());
        }
    }
}