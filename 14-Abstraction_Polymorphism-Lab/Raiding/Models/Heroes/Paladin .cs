using Raiding.Models;

public class Paladin: Healer
{
    private string name;

    public Paladin(string name) : base(name)
    {
        
    }

    public override int Power => 100;
}