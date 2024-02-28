namespace Players;

public class Hero
{
    private string _username;
    private int _level;

    public Hero(string userName, int level) 
    {
        this.Username = userName;
        this.Level = level;
    }

    public string Username { get; set; }

    public int Level { get; set; }
    

    public override string ToString()
    {
        return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
    }
}
