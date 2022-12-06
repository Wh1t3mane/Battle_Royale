namespace Battle_royale;

public class Fighter : Enemy
{
    private int health;
    private int maxhealth;
    private bool islive;
    private string name = "Fighter";
    private int damageBonus;
    
    /*public Fighter(string name)
    {
        this.name = name;
    }*/

    public override string ToString()
    {
        return name;
    }
    
    public int Attack_F(){
        var random = new Random();
        damageBonus = random.Next(15, 25);
        return damageBonus;
    }
}