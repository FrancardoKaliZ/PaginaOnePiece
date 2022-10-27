using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;

namespace PaginaOnePiece
{
    public static class BD
    {
        private static string _connectionString = @"Server=DESKTOP-C3LD3QR\SQLEXPRESS;DataBase = OnePiece;Trusted_Connection=True;";
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
        public static PersonajeXTemporada GetPersonajeByID(int IdPersonaje=null, int IdTemporada=null)
        {
            PersonajeXTemporada miPersonaje = null;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT PersonajeXTemporada.*, R.NombreRaza, P.*, M.NombreMar FROM Personaje P ";
                sql += " INNER JOIN PersonajeXTemporada PxT ON P.IdPersonaje = PxT.IdPersonaje";
                sql += " INNER JOIN Raza R ON P.IdRaza = R.IdRaza";
                sql += " INNER JOIN Mar M ON P.IdMar = M.IdMar";
                sql += "INNER JOIN HakiArmadura HA ON PxT.IdHakiArmadura = HA.IdHakiArmadura";
                sql += "INNER JOIN HakiObservacion HO ON PxT.IdHakiObservacion = HO.IdHakiObservacion";
                sql += "INNER JOIN HakiRey HR ON PxT.IdHakiRey = HR.IdHakiRey";
                sql += "INNER JOIN Bando B ON PxT.IdBando = B.IdBando";
                sql += "INNER JOIN Tripulacion T ON PxT.IdTripulacion = T.IdTripulacion";
                sql += " WHERE P.IdPersonaje = @pIdPersonaje and PxT.IdTemporada = @pIdTemporada ";
                miPersonaje = db.QueryFirstOrDefault<PersonajeXTemporada>(sql, new{pIdPersoanje = IdPersonaje, pIdTemporada = IdTemporada});
            }
            return miPersonaje;
    }
        public static List<PersonajeXTemporada> ListarPersonajeXtemporada(int IdTemporada=null)
        {
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT PersonajeXTemporada.*, R.NombreRaza, P.*, M.NombreMar FROM Personaje P ";
                sql += " INNER JOIN PersonajeXTemporada PxT ON P.IdPersonaje = PxT.IdPersonaje";
                sql += " INNER JOIN Raza R ON P.IdRaza = R.IdRaza";
                sql += " INNER JOIN Mar M ON P.IdMar = M.IdMar";
                sql += "INNER JOIN HakiArmadura HA ON PxT.IdHakiArmadura = HA.IdHakiArmadura";
                sql += "INNER JOIN HakiObservacion HO ON PxT.IdHakiObservacion = HO.IdHakiObservacion";
                sql += "INNER JOIN HakiRey HR ON PxT.IdHakiRey = HR.IdHakiRey";
                sql += "INNER JOIN Bando B ON PxT.IdBando = B.IdBando";
                sql += "INNER JOIN Tripulacion T ON PxT.IdTripulacion = T.IdTripulacion";
                sql += " WHERE P.IdPersonaje = @pIdPersonaje and PxT.IdTemporada = @pIdTemporada ";
                _ListaPersonajesXTemporada = db.Query<PersonajeXTemporada>(sql, new{pIdTemporada = IdTemporada}).ToList();
            }
            return _ListaPersonajesXTemporada;
    }
  }
} 