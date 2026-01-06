using System.ComponentModel;

class Banda
{
    List<Album> albums = new List<Album>();
    List<Musica> musicas = new List<Musica>();
    List<Genero> generos = new List<Genero>();
    public string Nome { get; set; }
    
    
    public void AddGenero(Genero genero)
    {
        generos.Add(genero);
    }
    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }
    public void AddMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void MostrarInfo()
    {
        Console.WriteLine("Nome da Banda: " + Nome);
        Console.WriteLine("Gêneros da Banda:");
        foreach (var genero in generos)
        {
            Console.WriteLine($"- {genero.Nome}");
        }
        Console.WriteLine("Músicas da Banda:");
        // musicas da banda
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }

        Console.WriteLine("Álbuns da Banda:");
        foreach (var album in albums)   
        {
            Console.WriteLine($"- {album.Titulo}");
            album.ListarMusicas();
        }
    }


    public void ListarAlbums()
    {
        Console.WriteLine($"Álbuns da banda {Nome}:");
        foreach (var album in albums)
        {
            Console.WriteLine($"- {album.Titulo} ({album.AnoLancamento})");
        }
    }
    public void ListarMusicas()
    {
        Console.WriteLine($"Músicas da banda {Nome}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.Nome} ({musica.Duracao}s)");
        }
    }

}