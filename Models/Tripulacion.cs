using System;

namespace PaginaOnePiece
{
    public class Tripulacion
    {
        private int _IdTripulacion;
        private string _NombreTripulacion;
        private string _Foto;

        public Tripulacion(int IdTripulacion, string NombreTripulacion, string Foto)
        {
            _IdTripulacion = IdTripulacion;
            _NombreTripulacion = NombreTripulacion;
            _Foto = Foto;
        }
        public Tripulacion()
        {}

        public int IdTripulacion
    {
        get{return _IdTripulacion;}
        set{_IdTripulacion=value;}
    }
        public string NombreTripulacion
    {
        get{return _NombreTripulacion;}
        set{_NombreTripulacion=value;}
    }
        public string NombreTripulacion
    {
        get{return _NombreTripulacion;}
        set{_NombreTripulacion=value;}
    }
        public string Foto
    {
        get{return _Foto;}
        set{_Foto=value;}
    }

  }

}