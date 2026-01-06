class Podcast
{
    List<Episodio> episodios = new List<Episodio>();
    public string Title { get; }
    public string Host { get; }
    public int Episodes => episodios.Count;

    public Podcast(string title, string host)
    {
        Title = title;
        Host = host;

    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Podcast Title: {Title}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Number of Episodes: {Episodes}");
        foreach (var episodio in episodios.OrderBy(e => e.Orden))
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
    public void AddEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
}