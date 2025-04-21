using T9;

class Program
{
    public static void Main(string[] args)
    {
        Transport[] transports = new Transport[]
        {
            new Transport(120),
            new Car(80),
            new Bicycle(15),
            new Car(100),
            new Bicycle(50)
        };

        foreach (Transport t in transports)
        {
            t.Move();
        }
    }
}