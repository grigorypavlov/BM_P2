namespace Constructors;

public class Person
{
    public string Name { get; set; }
    public int Alter { get; set; }

    public Person() : this(string.Empty, 0)
    {
    }

    public Person(string name, int alter)
    {
        this.Name = name;
        this.Alter = alter;
    }
}