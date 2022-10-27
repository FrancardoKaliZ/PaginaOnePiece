using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;

namespace PaginaOnePiece
{
    public static class BD
    {
        private static string _connectionString = @"Server=A-PHZ2-CIDI-050\SQLEXPRESS;DataBase = OnePiece;Trusted_Connection=True;";
        private static List<PersonajeXTemporada> _ListaPersonajesXTemporada = new List<PersonajeXTemporada>();
        private static List<Temporada> _ListaTemporadas = new List<Temporada>();
        private static List<Mar> _ListaMares = new List<Mar>();
        private static List<Personaje> _ListaPersonajes = new List<Personaje>();


        public static List<Temporada> ListarTemporadasByID(int IdMar)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Temporada WHERE IdMar = @pIdMar";
                _ListaTemporadas = db.Query<Temporada>(sql, new { pIdMar = IdMar }).ToList();
            }
            return _ListaTemporadas;
        }

        public static List<Personaje> ListarPersonajes()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Personaje";
                _ListaPersonajes = db.Query<Personaje>(sql).ToList();
            }
            return _ListaPersonajes;
        }
        public static List<Mar> ListarMares()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Mar";
                _ListaMares = db.Query<Mar>(sql).ToList();
            }
            return _ListaMares;
        }
        public static Personaje GetPersonajeByID(int IdPersonaje, int IdTemporada)
        {
            Personaje miPersonaje = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Personaje P INNER JOIN PersonajeXTemporada PxT ON P.IdPersonaje = PxT.IdPersonaje INNER JOIN Raza R ON P.IdRaza = R.IdRaza INNER JOIN Mar M ON P.IdMar = M.IdMar WHERE P.IdPersonaje = @pIdPersonaje and PxT.IdTemporada = @pIdTemporada ";
                miPersonaje = db.QueryFirstOrDefault<Personaje>(sql, new { pIdPersoanje = IdPersonaje, pIdTemporada = IdTemporada });
            }
            return miPersonaje;
        }
        public static void AgregarTemporada(Temporada temp)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Temporada(NombreTemporada, FechaInicio, FechaFin, InfoTemporada, Capitulos) VALUES(NombreTemporada, FechaInicio, FechaFin, InfoTemporada, Capitulos)";
                db.Execute(sql, new { NombreTemporada = temp.NombreTemporada, FechaInicio = temp.FechaInicio, FechaFin = temp.FechaFin, InfoTemporada = temp.InfoTemporada, capitulos = temp.Capitulos });
            }
        }
        public static void AgregarPersonaje(Personaje pers)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Personaje(NombrePersonaje,InfoPersonaje,IdMar,IdRaza) VALUES(NombrePersonaje,InfoPersonaje,IdMar,IdRaza)";
                db.Execute(sql, new { NombrePersonaje = pers.NombrePersonaje, InfoPersonaje = pers.InfoPersonaje, IdMar = pers.IdMar, IdRaza = pers.IdRaza});
            }
        }

    }
}