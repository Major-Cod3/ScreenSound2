Episodio episodio = new Episodio(1, "Introducción al Podcasting", 30);
episodio.convidadoEspecial("Ana Gómez");
Episodio episodio1 = new Episodio(2, "Entrevista con un Experto", 45);
episodio1.convidadoEspecial("Carlos Ruiz");
Episodio episodio2 = new Episodio(3, "Consejos para Nuevos Podcasters", 25);
episodio2.convidadoEspecial("Laura Martínez");

Podcast podcast = new Podcast("Mi Primer Podcast", "Juan Pérez");
podcast.AddEpisodio(episodio);
podcast.AddEpisodio(episodio1);
podcast.AddEpisodio(episodio2);

podcast.DisplayInfo();