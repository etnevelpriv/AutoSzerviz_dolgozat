namespace AutoSzerviz_dolgozat
{
    public class Szerviz
    {
        private List<Jarmu> jarmuLista = new List<Jarmu>();
        public void JarmuFelvetel(Jarmu jarmu)
        {
            jarmuLista.Add(jarmu);
            Console.WriteLine("A jármű megérkezett a szervízbe.");
        }
        public void InformaciokListazasa()
        {
            foreach (Jarmu jarmu in jarmuLista)
            {
                jarmu.InformaciotAd();
            }
            return;
        }
        public void CsoportSzerviz(int dij)
        {
            foreach (Jarmu jarmu in jarmuLista)
            {
                if (jarmu.SzervizSzukseges)
                {
                    jarmu.Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"A {jarmu.Rendszam} szervizelése jelenleg nem szükséges.");
                }
            }
        }
    }
}