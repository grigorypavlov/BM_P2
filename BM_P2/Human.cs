namespace BM_P2;

public class Human
{
    public string Read(IPublication publication)
    {
        return publication.GetInformation();
    }
}