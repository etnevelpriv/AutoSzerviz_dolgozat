
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
        }
    }
}