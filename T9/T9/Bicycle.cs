namespace T9;

public class Bicycle : Transport
{
    
    public Bicycle(int speed) : base(speed)
    {
        this.Speed = speed;
    }

    public override void Move()
    {
        Console.WriteLine("Велосипед едет со скоростью "+ Speed +  " км/ч.");
    }
}