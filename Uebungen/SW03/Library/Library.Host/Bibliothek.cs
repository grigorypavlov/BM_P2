namespace Library.Host;

public class Bibliothek
{
    private List<Buch> buecher;

    public Bibliothek()
    {
        buecher = new List<Buch>();
    }

    public void VorhandeneBuecher()
    {
        foreach (var buch in buecher)
        {
            Console.WriteLine(buch.ToString());
        }
    }

    public void BuchHinzufuegen(Buch buch)
    {
        this.buecher.Add(buch);
    }
}