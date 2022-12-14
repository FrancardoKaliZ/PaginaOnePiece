
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;

namespace PaginaOnePiece.Models;

    public static class BD
    {
<<<<<<< HEAD
        private static string _connectionString = @"Server=A-PHZ2-CIDI-022;DataBase=OnePiece;Trusted_Connection=True;";
=======
        private static string _connectionString = @"Server=A-PHZ2-CIDI-019;DataBase=OnePiece;Trusted_Connection=True;";
>>>>>>> 71ae565e5f3a1db28ebeb0a1095863b812d80895

        private static List<PersonajeXTemporada> _ListaPersonajesXTemporada = new List<PersonajeXTemporada>();
        private static List<Temporada> _ListaTemporadas = new List<Temporada>();
        private static List<Temporada> _ListaTemporadasById = new List<Temporada>();
        private static List<Mar> _ListaMares = new List<Mar>();
        private static List<Personaje> _ListaPersonajes = new List<Personaje>();
        private static List<Raza> _ListaRazas = new List<Raza>();
        private static List<Bando> _ListaBandos = new List<Bando>();
        private static List<HakiArmadura> _ListaHakiArmadura = new List<HakiArmadura>();
        private static List<HakiObservacion> _ListaHakiObservacion = new List<HakiObservacion>();
        private static List<HakiRey> _ListaHakiRey = new List<HakiRey>();
        private static List<Tripulacion> _ListaTripulacion = new List<Tripulacion>();
        
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
         public static List<Raza> ListarRazas()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Raza";
                _ListaRazas = db.Query<Raza>(sql).ToList();
            }
            return _ListaRazas;
        }
            public static List<Bando> ListarBandos()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Bando";
                _ListaBandos = db.Query<Bando>(sql).ToList();
            }
            return _ListaBandos;
        }
            public static List<HakiArmadura> ListarHakiA()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM HakiArmadura";
                _ListaHakiArmadura = db.Query<HakiArmadura>(sql).ToList();
            }
            return _ListaHakiArmadura;
        }
            public static List<HakiObservacion> ListarHakiO()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM HakiObservacion";
                _ListaHakiObservacion = db.Query<HakiObservacion>(sql).ToList();
            }
            return _ListaHakiObservacion;
        }
            public static List<HakiRey> ListarHakiR()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM HakiRey";
                _ListaHakiRey = db.Query<HakiRey>(sql).ToList();
            }
            return _ListaHakiRey;
        }
            public static List<Tripulacion> ListarTripulacion()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Tripulacion";
                _ListaTripulacion = db.Query<Tripulacion>(sql).ToList();
            }
            return _ListaTripulacion;
        }
        public static PersonajeXTemporada GetPersonajeByID(int IdPersonaje, int IdTemporada)
        {
            PersonajeXTemporada miPersonaje = null;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT PxT.*, R.NombreRaza, P.*, M.NombreMar, HA.estadoHA, HO.estadoHO, HR.estadoHR, B.NombreBando, T.NombreTripulacion FROM Personaje P ";
                sql += " INNER JOIN PersonajeXTemporada PxT ON P.IdPersonaje = PxT.IdPersonaje";
                sql += " INNER JOIN Raza R ON P.IdRaza = R.IdRaza";
                sql += " INNER JOIN Mar M ON P.IdMar = M.IdMar";
                sql += " INNER JOIN HakiArmadura HA ON PxT.IdHakiArmadura = HA.IdHakiArmadura";
                sql += " INNER JOIN HakiObservacion HO ON PxT.IdHakiObservacion = HO.IdHakiObservacion";
                sql += " INNER JOIN HakiRey HR ON PxT.IdHakiRey = HR.IdHakiRey";
                sql += " INNER JOIN Bando B ON PxT.IdBando = B.IdBando";
                sql += " INNER JOIN Tripulacion T ON PxT.IdTripulacion = T.IdTripulacion";
                sql += " WHERE P.IdPersonaje = @pIdPersonaje and PxT.IdTemporada = @pIdTemporada ";
                miPersonaje = db.QueryFirstOrDefault<PersonajeXTemporada>(sql, new{pIdPersonaje = IdPersonaje, pIdTemporada = IdTemporada});
            }
            return miPersonaje;
    }
        public static List<PersonajeXTemporada> ListarPersonajeXtemporada(int IdTemporada)
        {
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT PxT.*, R.NombreRaza, P.*, M.NombreMar, HA.estadoHA, HO.estadoHO, HR.estadoHR, B.NombreBando, T.NombreTripulacion FROM Personaje P ";
                sql += " INNER JOIN PersonajeXTemporada PxT ON P.IdPersonaje = PxT.IdPersonaje";
                sql += " INNER JOIN Raza R ON P.IdRaza = R.IdRaza";
                sql += " INNER JOIN Mar M ON P.IdMar = M.IdMar";
                sql += " INNER JOIN HakiArmadura HA ON PxT.IdHakiArmadura = HA.IdHakiArmadura";
                sql += " INNER JOIN HakiObservacion HO ON PxT.IdHakiObservacion = HO.IdHakiObservacion";
                sql += " INNER JOIN HakiRey HR ON PxT.IdHakiRey = HR.IdHakiRey";
                sql += " INNER JOIN Bando B ON PxT.IdBando = B.IdBando";
                sql += " INNER JOIN Tripulacion T ON PxT.IdTripulacion = T.IdTripulacion";
                sql += " WHERE PxT.IdTemporada = @pIdTemporada ";
                _ListaPersonajesXTemporada = db.Query<PersonajeXTemporada>(sql, new{pIdTemporada = IdTemporada}).ToList();
            }
            return _ListaPersonajesXTemporada;
    }
        public static void AgregarTemporada(Temporada temp)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Temporada(NombreTemporada, FechaInicio, FechaFin, InfoTemporada, Capitulos, Foto, IdMar) VALUES(@NombreTemporada, @FechaInicio, @FechaFin, @InfoTemporada, @Capitulos,@Foto, @IdMar)";
                db.Execute(sql, new { NombreTemporada = temp.NombreTemporada, FechaInicio = temp.FechaInicio, FechaFin = temp.FechaFin, InfoTemporada = temp.InfoTemporada, Capitulos = temp.Capitulos, Foto = temp.Foto , IdMar = temp.IdMar});
            }
        }
        public static int AgregarPersonaje(Personaje pers)
        {
            int devolver=-1;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Personaje(NombrePersonaje,InfoPersonaje,IdMar,IdRaza,Foto) VALUES(@NombrePersonaje,@InfoPersonaje,@IdMar,@IdRaza,@Foto)";
                db.Execute(sql, new { NombrePersonaje = pers.NombrePersonaje, InfoPersonaje = pers.InfoPersonaje, IdMar = pers.IdMar, IdRaza = pers.IdRaza, Foto = pers.Foto});
                devolver = db.QueryFirstOrDefault<int>("Select MAX(IdPersonaje) FROM Personaje");
            }
            return devolver;
        }
        public static void AgregarPersonajeInfoXtemporada(PersonajeXTemporada personajeXt)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO PersonajeXTemporada(IdPersonaje,IdTemporada,IdBando,IdHakiArmadura,IdHakiObservacion,IdHakiRey,IdTripulacion,Recompensa) VALUES(@IdPersonaje,@IdTemporada,@IdBando,@IdHakiArmadura,@IdHakiObservacion,@IdHakiRey,@IdTripulacion,@Recompensa)";
                db.Execute(sql, new {IdPersonaje = personajeXt.IdPersonaje, IdTemporada = personajeXt.IdTemporada , IdBando = personajeXt.IdBando , IdHakiArmadura = personajeXt.IdHakiArmadura, IdHakiObservacion = personajeXt.IdHakiObservacion, IdHakiRey = personajeXt.IdHakiRey, IdTripulacion = personajeXt.IdTripulacion, Recompensa = personajeXt.Recompensa});
            }
        }
         public static void EliminarPersonaje(int IdPersonaje)
        {
            string sql= "DELETE FROM Personajes WHERE idPersonaje = @PIdPersonaje";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
               db.Execute(sql, new{PIdPersonaje =IdPersonaje });
            }
        }
         public static void EliminarPersonajeXtemp(int IdTemporada)
        {
            string sql= "DELETE FROM PersonajeXTemporada WHERE IdTemporada = @IdTemporada";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
               db.Execute(sql, new{IdTemporada =IdTemporada });
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

           public static Mar verDetalleMar(int IdMar)
        {
            Mar miMar= null;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Mar WHERE IdMar = @PIdMar";
                miMar = db.QueryFirstOrDefault<Mar>(sql, new{PIdMar= IdMar});
            }
            return miMar;
        }
        public static Personaje verDetallePersonaje(int IdPersonaje)
        {
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Personaje WHERE IdPersonaje = @PIdPersonaje";
                return db.QueryFirstOrDefault<Personaje>(sql, new{PIdPersonaje= IdPersonaje});
            }
        }
        public static PersonajeXTemporada GetPersonajeByIDNoTemp(int IdPersonaje)
        {
            PersonajeXTemporada miPersonaje = null;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT PxT.*, R.NombreRaza, P.*, M.NombreMar, HA.estadoHA, HO.estadoHO, HR.estadoHR, B.NombreBando, T.NombreTripulacion FROM Personaje P ";
                sql += " INNER JOIN PersonajeXTemporada PxT ON P.IdPersonaje = PxT.IdPersonaje";
                sql += " INNER JOIN Raza R ON P.IdRaza = R.IdRaza";
                sql += " INNER JOIN Mar M ON P.IdMar = M.IdMar";
                sql += " INNER JOIN HakiArmadura HA ON PxT.IdHakiArmadura = HA.IdHakiArmadura";
                sql += " INNER JOIN HakiObservacion HO ON PxT.IdHakiObservacion = HO.IdHakiObservacion";
                sql += " INNER JOIN HakiRey HR ON PxT.IdHakiRey = HR.IdHakiRey";
                sql += " INNER JOIN Bando B ON PxT.IdBando = B.IdBando";
                sql += " INNER JOIN Tripulacion T ON PxT.IdTripulacion = T.IdTripulacion";
                sql += " WHERE P.IdPersonaje = @pIdPersonaje";
                miPersonaje = db.QueryFirstOrDefault<PersonajeXTemporada>(sql, new{pIdPersonaje = IdPersonaje});
            }
            return miPersonaje;
         }
           public static void EditarPersonaje(Personaje per)
        {
            string sql= "UPDATE Personaje SET NombrePersonaje=@NombrePersonaje, InfoPersonaje=@InfoPersonaje, IdMar=@IdMar,  IdRaza=@IdRaza,Foto=@Foto WHERE IdPersonaje = @IdPersonaje";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
<<<<<<< HEAD
               db.Execute(sql, new{IdPersonaje=per.IdPersonaje,NombrePersonaje =per.NombrePersonaje,InfoPersonaje=per.InfoPersonaje, IdMar=per.IdMar, IdRaza=per.IdRaza , Foto=per.Foto});
            }
        }
            public static void EditarPersonajeXtemporada(PersonajeXTemporada per)
        {
            string sql= "UPDATE PersonajeXTemporada SET IdPersonaje=@IdPersonaje,IdTemporada=@IdTemporada,IdBando=@IdBando,IdHakiArmadura=@IdHakiArmadura,IdHakiObservacion=@IdHakiObservacion,IdHakiRey=@IdHakiRey,IdTripulacion=@IdTripulacion,Recompensa=@Recompensa WHERE IdPersonaje = @IdPersonaje";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
               db.Execute(sql, new{IdPersonaje=per.IdPersonaje, IdTemporada=per.IdTemporada, IdBando=per.IdBando, IdHakiArmadura=per.IdHakiArmadura, IdHakiObservacion=per.IdHakiObservacion, IdHakiRey=per.IdHakiRey,IdTripulacion=per.IdTripulacion,Recompensa=per.Recompensa});
=======
               db.Execute(sql, new{NombrePersonaje = per.NombrePersonaje,InfoPersonaje = per.InfoPersonaje, IdMar = per.IdMar,IdRaza = per.IdRaza,Foto = per.Foto});
>>>>>>> 71ae565e5f3a1db28ebeb0a1095863b812d80895
            }
            return per;
        }
    }
