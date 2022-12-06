namespace Battle_royale;

public class Game 
{
    Object[] pole_hracu = new Object[3] {typeof(Enemy), typeof(Fighter), typeof(Knight)};
    
    public void Start()
    {
        for (int i = 0; i < pole_hracu.Length; i++)
        {
            Console.WriteLine(pole_hracu[i]);
        }
    }
    
    
}

