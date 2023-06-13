class Candidato 
{
    private int IdCandidato {get; set;}
    private int IdPartido {get; set;}
    private string Apellido {get; set;}
    private string Nombre {get; set;}
    private DateTime FechaNacimiento {get; set;}
    private string Foto {get; set;}
    private string Postulacion {get; set;}

    public Candidato()
    {
        IdCandidato = 0;
    }

    public Candidato(int idCand, int idPar, string ape, string nom, DateTime fechaN, string fo, string post)
    {
        IdCandidato = idCand;
        IdPartido = idPar;
        Apellido = ape;
        Nombre = nom;
        FechaNacimiento = fechaN;
        Foto = fo;
        Postulacion = post;
    }
}