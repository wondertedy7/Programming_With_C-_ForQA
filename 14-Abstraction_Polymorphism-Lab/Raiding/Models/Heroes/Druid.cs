using Raiding.Models;

public class Druid : Healer
{
    private string name;

    public Druid(string name) : base(name)
    {
        
    }

    public override int Power => 80;
}