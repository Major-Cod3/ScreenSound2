class Episodio
{
   private List<string> convidados = new List<string>();
    public string Titulo { get;}
    public int Orden { get;}
    public string Resumo => $"{Orden}. {Titulo}  ({DuracionMinutos} min) - {string.Join(", ", convidados)}" ;
    public int DuracionMinutos { get;  }

    public Episodio(int orden, string titulo, int duracionMinutos)
    {

        Titulo = titulo;
        DuracionMinutos = duracionMinutos;
        Orden = orden;


    }
    public void convidadoEspecial(string nomeConvidado)
    {
        convidados.Add(nomeConvidado);
    }
}