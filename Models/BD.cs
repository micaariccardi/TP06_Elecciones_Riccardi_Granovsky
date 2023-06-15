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

    public void EliminarCandidato(int idCandidato)
    {
        string sql = "Delete from Candidato Where IdCandidato = @pIdCandidato";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {pIdCandidato = idCandidato});
        }
    }

    public Partido VerInfoPartido(int idPartido)
    {
        Partido partidoADevolver = null;
        string sql = "Select * from Partido Where IdPartido = @pIdPartido";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            partidoADevolver = db.QueryFirstOrDefault<Partido>(sql, new {pIdPartido = IdPartido});
        }
        return partidoADevolver;
    }

    public Candidato VerInfoCandidato(int idCandidato)
    {
        Candidato aDevolver = null;
        string sql = "Select * from Candidato Where IdCandidato = @pIdCandidato";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            aDevolver = db.QueryFirstOrDefault<Partido>(sql, new {pIdCandidato = IdCandidato});
        }
        return aDevolver;
    }

    public List<Partido> ListarPartidos()
    {
        List<Partido> listaPartidos = new List<Partido>();
        string sql = "Select * from Partido";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            listaPartidos = db.Query<Partido>(sql).ToList();
        }
        return listaPartidos;
    }
 
    public List<Candidato> ListarCandidatos(int idPartido)
    {
        List<Candidato> listaCandidatos = new List<Candidato>();
        string sql = "Select * from Candidato Where IdPartido = @pIdPartido";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            listaCandidatos = db.Query<Candidato>(sql, new {pIdPartido = idPartido}).ToList();
        }
        return listaCandidatos;
    }

}

