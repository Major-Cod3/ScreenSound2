class Musica
{
    public Musica(Artista artista){}
    internal string nome;
    internal int duracao;

    public string Nome { get; set; }
   
    public Genero Genero { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao => $"A música {Nome}";
    

    public void fichatecnica()
    {
        Console.WriteLine("Nome: " + Nome);

        Console.WriteLine("Duração: " + Duracao + "s");
        Console.WriteLine("Disponível: " + (Disponivel ? "Sim" : "Não"));
    }
}
