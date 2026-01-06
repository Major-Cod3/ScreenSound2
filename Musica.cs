class Musica
{
    internal string nome;
    internal int duracao;

    public string Nome { get; set; }
    public string Artista { get; set; }
    public Genero Genero { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao => $"A música {Nome} e do cantor: {Artista}";
    

    public void fichatecnica()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Artista: " + Artista);

        Console.WriteLine("Duração: " + Duracao + "s");
        Console.WriteLine("Disponível: " + (Disponivel ? "Sim" : "Não"));
    }
}
