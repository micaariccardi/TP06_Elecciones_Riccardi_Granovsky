using System.Data.SqlClient;
using Dapper;
static class BD
{

    private static string _connectionString = @"Server=localhost; DataBase=Elecciones2023; Trusted_Connection=True;";
    public void AgregarCandidato(Candidato can)
    {
        string sql = "Insert into Candidato(IdCandidato, IdPartido, Apellido, Nombre, FechaNacimiento, Foto, Postulacion) values (@pIdCandidato, @pIdPartido, @pApellido, @pNombre, @pFechaNacimiento, @pFoto, @pPostulacion)";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {pIdCandidato = can.Nombre, pIdPartido = can.IdPartido, pApellido = can.Apellido, pNombre = can.Nombre, pFechaNacimiento = can.FechaNacimiento, pFoto = can.Foto, pPostulacion = can.Postulacion});
        }
    }

    /* 
    public void EliminarCandidato(int idCandidato)
    {
        
    }

    public void VerInfoPartido(int idCandidato)
    {

    }

    public void VerIncoCandidato(int idCandidato)
    {

    }

    public List<Partido> ListarPartidos()
    {

    }

    public List<Candidato> ListarCandidatos(int idPartido)
    {

    }

     */
}

