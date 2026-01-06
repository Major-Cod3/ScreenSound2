Artista artista1 = new Artista("Baco Exu do Blues");
Console.WriteLine(artista1.Nome);
Genero genero = new Genero();
genero.Nome = "Rap";

Album album = new Album();
album.Titulo = "QVVJFA?";
album.Artista = "Baco Exu do Blues";

Musica musica1 = new Musica( artista1);
musica1.Nome = "20 ligacoes";


musica1.Genero = genero;
musica1.Duracao = 180;
Musica musica2 = new Musica(artista1);
musica2.Nome = "Sulicidio";

musica2.Duracao = 200;
musica2.Genero = genero;

album.AddMusica(musica1);
album.AddMusica(musica2);
Genero genero1 = new Genero();
genero1.Nome = "blues";
artista1.AddAlbum(album);
artista1.AddMusica(musica1);
artista1.AddMusica(musica2);
artista1.MostrarInfo();

