
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;

namespace PaginaOnePiece.Models;

    public static class BD
    {
        private static string _connectionString = @"Server=A-PHZ2-CIDI-033\;DataBase=OnePiece;Trusted_Connection=True;";
        private static List<PersonajeXTemporada> _ListaPersonajesXTemporada = new List<PersonajeXTemporada>();
        private static List<Temporada> _ListaTemporadas = new List<Temporada>();
        private static List<Temporada> _ListaTemporadasById = new List<Temporada>();
        private static List<Mar> _ListaMares = new List<Mar>();
        private static List<Personaje> _ListaPersonajes = new List<Personaje>();


            public static List<Temporada> ListarTemporadas()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Temporada" ;
                _ListaTemporadas = db.Query<Temporada>(sql).ToList();
            }
            return _ListaTemporadas;
        }

        public static List<Temporada> ListarTemporadasById(int IdMar)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Temporada WHERE IdMar = @pIdMar";
                _ListaTemporadasById = db.Query<Temporada>(sql, new { pIdMar = IdMar }).ToList();
            }
            return _ListaTemporadasById;
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
        
        public static PersonajeXTemporada GetPersonajeByID(int IdPersonaje, int IdTemporada)
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
        public static List<PersonajeXTemporada> ListarPersonajeXtemporada(int IdTemporada)
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
                sql += " WHERE PxT.IdTemporada = @pIdTemporada ";
                _ListaPersonajesXTemporada = db.Query<PersonajeXTemporada>(sql, new{pIdTemporada = IdTemporada}).ToList();
            }
            return _ListaPersonajesXTemporada;
    }
        public static void AgregarTemporada(Temporada temp)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Temporada(NombreTemporada, FechaInicio, FechaFin, InfoTemporada, Capitulos, Foto) VALUES(@NombreTemporada, @FechaInicio, @FechaFin, @InfoTemporada, @Capitulos,@Foto)";
                db.Execute(sql, new { NombreTemporada = temp.NombreTemporada, FechaInicio = temp.FechaInicio, FechaFin = temp.FechaFin, InfoTemporada = temp.InfoTemporada, Capitulos = temp.Capitulos, Foto = temp.Foto });
            }
        }
        public static void AgregarPersonaje(Personaje pers)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Personaje(NombrePersonaje,InfoPersonaje,IdMar,IdRaza,Foto) VALUES(@NombrePersonaje,@InfoPersonaje,@IdMar,@IdRaza,@Foto)";
                db.Execute(sql, new { NombrePersonaje = pers.NombrePersonaje, InfoPersonaje = pers.InfoPersonaje, IdMar = pers.IdMar, IdRaza = pers.IdRaza, Foto = pers.Foto});
            }
        }
        public static void AgregarPersonajeInfoXtemporada(PersonajeXTemporada personajeXt)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO PersonajeXTemporada(IdPersonaje,IdTemporada,IdBando,IdHakiArmadura,IdHakiObservacion,IdHakiRey,IdTripulacion) VALUES(@IdPersonaje,@IdTemporada,@IdBando,@IdHakiArmadura,@IdHakiObservacion,@IdHakiRey,@IdTripulacion)";
                db.Execute(sql, new {IdPersonaje = personajeXt.IdPersonaje, IdTemporada = personajeXt.IdTemporada , IdBando = personajeXt.IdBando , IdHakiArmadura = personajeXt.IdHakiArmadura, IdHakiObservacion = personajeXt.IdHakiObservacion, IdHakiRey = personajeXt.IdHakiRey, IdTripulacion = personajeXt.IdTripulacion});
            }
        }
         public static void EliminarPersonaje(int IdPersonaje)
        {
            string sql= "DELETE FROM Personajes WHERE idPErsonaje = @PIdPersonaje";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
               db.Execute(sql, new{PIdPersonaje =IdPersonaje });
            }
        }

          public static void EliminarTemporada(int IdTemporada)
        {
            string sql= "DELETE FROM Temporada WHERE idTemporada = @PIdTemporada";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
               db.Execute(sql, new{PIdTemporada =IdTemporada });
            }
        }

            public static Temporada verDetalleTemporada(int IdTemporada)
        {
            Temporada miTemporada = null;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Temporada WHERE IdTemporada = @PIdTemporada";
                miTemporada = db.QueryFirstOrDefault<Temporada>(sql, new{PIdTemporada= IdTemporada});
            }
            return miTemporada;
        }
    }
