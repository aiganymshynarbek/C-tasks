namespace T9;

public class Car : Transport
{
    

    public Car(int speed) : base(speed)
    {
        this.Speed = speed;
    }

    public override void Move()
    {
        Console.WriteLine("Машина едет со скоростью "+ Speed +  " км/ч.");
    }
}