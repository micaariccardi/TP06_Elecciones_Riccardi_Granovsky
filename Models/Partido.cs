class Partido {
    public int IdPartido {get; set;}
    public string Nombre {get; set;}
    public string Logo {get; set;}
    public string SitioWeb {get; set;}
    public DateTime FechaFundacion{get; set;}
    public int CantidadDiputados {get; set;}
    public int CantidadSenadores {get; set;}

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