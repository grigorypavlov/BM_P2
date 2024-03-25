namespace BM_P2;

public class MyCollection
{
    private string[] data;

    public MyCollection(int size)
    {
        data = new string[size];
    }

    public string this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
}