namespace T10;

public class Video : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Video is playing");
    }

    public void Stop()
    {
        Console.WriteLine("Video stopped");
    }
}