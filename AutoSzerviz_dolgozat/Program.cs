
namespace AutoSzerviz_dolgozat
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Szerviz szerviz = new Szerviz();
            Jarmu ujAuto = new Jarmu("rmb-345", 12, 200, 80);
            Console.WriteLine(ujAuto.SzervizSzukseges);
        }
    }
}