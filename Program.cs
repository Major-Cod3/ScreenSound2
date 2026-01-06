Genero genero = new Genero();
genero.Nome = "Rap";

Album album = new Album();
album.Titulo = "QVVJFA?";
album.Artista = "Baco Exu do Blues";

Musica musica1 = new Musica();
musica1.Nome = "20 ligacoes";
musica1.Artista = "Baco Exu do Blues";

musica1.Genero = genero;
musica1.Duracao = 180;
Musica musica2 = new Musica();
musica2.Nome = "Sulicidio";
musica2.Artista = "Baco Exu do Blues";
musica2.Duracao = 200;
musica2.Genero = genero;

album.AddMusica(musica1);
album.AddMusica(musica2);
Genero genero1 = new Genero();
genero1.Nome = "blues";
Banda banda = new Banda();
banda.Nome = "999";
banda.AddGenero(genero);
banda.AddGenero(genero1);
banda.AddAlbum(album);
banda.AddMusica(musica1);
banda.AddMusica(musica2);
banda.MostrarInfo();