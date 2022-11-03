using System;

namespace PaginaOnePiece
{
    public class HakiRey
    {
        private int _IdHakiRey;
        private string _EstadoHR;

        public HakiRey(int IdHakiRey, string EstadoHR)
        {
            _IdHakiRey = IdHakiRey;
            _EstadoHR = EstadoHR;
        }
        public  HakiRey()
        {}
        
        public int IdHakiRey
    {
        get{return _IdHakiRey;}
        set{_IdHakiRey=value;}
    }
        public string EstadoHR
    {
        get{return _EstadoHR;}
        set{_EstadoHR=value;}
    }
  }
}