class Album 
{

    internal string titulo;
    internal string artista;
    internal int anoLancamento;
    private List<Musica> musicas = new List<Musica>();
    public int Duracao => musicas.Sum(m => m.Duracao);
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int AnoLancamento { get; set; }
    public int NumeroDeFaixas { get; set; }
    public string Genero { get; set; }
    public string Descricao => $"O álbum {Titulo} do artista: {Artista}, lançado em {AnoLancamento}, gênero: {Genero}";
    public void AddMusica(Musica musica)
    {   musicas.Add(musica);
       
    }
    public void ListarMusicas()
    {
        Console.WriteLine($"Músicas do álbum {Titulo}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.Nome} ({musica.Duracao}s)");
        }
    }
}