namespace T10;

public class Music : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Music is playing");
    }

    public void Stop()
    {
        Console.WriteLine("Music stopped");
    }
}