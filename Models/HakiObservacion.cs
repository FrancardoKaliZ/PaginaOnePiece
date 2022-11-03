using System;

namespace PaginaOnePiece
{
    public class HakiObservacion
    {
        private int _IdHakiObservacion;
        private string _EstadoHO;

        public HakiObservacion(int IdHakiObservacion, string EstadoHO)
        {
            _IdHakiObservacion = IdHakiObservacion;
            _EstadoHO = EstadoHO;
        }
        public  HakiObservacion()
        {}
        
        public int IdHakiObservacion
    {
        get{return _IdHakiObservacion;}
        set{_IdHakiObservacion=value;}
    }
        public string EstadoHO
    {
        get{return _EstadoHO;}
        set{_EstadoHO=value;}
    }
  }
}