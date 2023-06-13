class Partido {
    private int IdPartido {get; set;}
    private string Nombre {get; set;}
    private string Logo {get; set;}
    private string SitioWeb {get; set;}
    private DateTime FechaFundacion{get; set;}
    private int CantidadDiputados {get; set;}
    private int CantidadSenadores {get; set;}

    public Partido ()
    {
        IdPartido = 0;
    }

    public Partido (int id, string no, string lo, string sitio, DateTime fecha, int cantDiputados, int cantSenadores)
    {
        IdPartido = id;
        Nombre = no;
        Logo = lo;
        SitioWeb = sitio;
        FechaFundacion = fecha;
        CantidadDiputados = cantDiputados;
        CantidadSenadores = cantSenadores;
    }
}