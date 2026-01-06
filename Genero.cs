class Genero
{
    public string Nome { get; set; }

    public static implicit operator Genero(string v)
    {
        throw new NotImplementedException();
    }
}