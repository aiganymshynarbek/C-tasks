using T10;

class Program
{
    public static void Main(string[] args)
    {
        IPlayable[] playables = new IPlayable[]
        {
            new Video(),
            new Music(),
            new Video()
        };

        foreach (IPlayable p in playables)
        {
            p.Play();
            p.Stop();
        }

    }
}