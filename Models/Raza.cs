using System;

namespace PaginaOnePiece
{
    public class Raza
    {
        private int _IdRaza;
        private string _NombreRaza;

        public Raza(int IdRaza,string NombreRaza)
        {
            _IdRaza = IdRaza;
            _NombreRaza = NombreRaza;
        }

        public Raza()
        {}

        public int IdRaza
    {
        get{return _IdRaza;}
        set{_IdRaza=value;}
    }
        public string NombreRaza
    {
        get{return _NombreRaza;}
        set{_NombreRaza=value;}
    }
  }
}