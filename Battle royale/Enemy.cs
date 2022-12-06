namespace Battle_royale;

public class Enemy
{
    private int health;
    private int maxhealth;
    private int damage;
    private bool islive;
    
    
    
    public int MaxHealth(){
        var random = new Random();
        maxhealth = random.Next(50, 100);
        return maxhealth;
    }
    
    public int Attack(){
        var random = new Random();
        damage = random.Next(10, 20);
        return damage;
    }
    
    public int Result(int damageinprogram){
        health = maxhealth - damageinprogram;
        return health;
    }
    /*public int Result() {
        return maxhealth = maxhealth - damage;
    }*/
    
    public int ReceiveDamage(int damage){
        health -= damage;
        return health;
    }
    
    public int Health(){
        /*return health;*/
        return maxhealth;
    }

    
    public bool IsLive(){
        if(maxhealth > 0){
            islive = true;
            return islive;
        }
        islive = false;
        return islive;
    }
    
    public Enemy PickOpponent(Enemy[] opponents)
    {
        int i = Random.Shared.Next(opponents.Length);
        return opponents[i];
    }
    
    
    
    
}

