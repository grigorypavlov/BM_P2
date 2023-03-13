namespace SW03;

public class MeineKlasse
{
    private string _name;
    private int _age;
    private MeineKlasse _meineKlasse;


    public MeineKlasse(string name, int age, MeineKlasse meineKlasse)
    {
        _name = name;
        _age = age;
        _meineKlasse = meineKlasse;
    }
    
    public const int MaxMembersInTheClub = 10;
    public static string MeinStatischesFeld { get; set; }

    public string MeinNichtStatischesFeld { get; set; }
    
    public int Add(int a, int b)
    {
        int result = a + b;
        return result;
    }
}
//
// class CallingClass
// {
//     private const int MaxValueForSomething;
//     
//     void MyMethod()
//     {
//         string statischerWert = MeineKlasse.MeinStatischesFeld;
//
//         MeineKlasse meineKlassenInstanz = new MeineKlasse();
//         string nichtStatischerWert = meineKlassenInstanz.MeinNichtStatischesFeld;
//         int maxMembersInTheClub = MeineKlasse.MaxMembersInTheClub;
//         meineKlassenInstanz.Add();
//
//
//         x = statischerWert;
//         y = nichtStatischerWert;
//     }
// }