namespace BM_P2;

public interface MyEntity<TId>
{
    TId Id { get; }
}

public class Rechnung : MyEntity<int>
{
    public int Id { get; }
}