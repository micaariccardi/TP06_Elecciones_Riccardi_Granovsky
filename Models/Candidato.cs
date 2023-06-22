public class Candidato 
{
    public int IdCandidato {get; set;}
    public int IdPartido {get; set;}
    public string Apellido {get; set;}
    public string Nombre {get; set;}
    public DateTime FechaNacimiento {get; set;}
    public string Foto {get; set;}
    public string Postulacion {get; set;}

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