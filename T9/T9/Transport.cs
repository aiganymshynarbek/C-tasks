namespace T9;

public class Transport
{
    public int Speed;

    public Transport()
    {
        
    }

    public Transport(int speed)
    {
        this.Speed = speed;
    }

    public virtual void Move()
    {
        Console.WriteLine("Транспорт едет со скоростью "+ Speed +  " км/ч.");
    }
}