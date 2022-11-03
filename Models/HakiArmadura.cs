using System;

namespace PaginaOnePiece
{
    public class HakiArmadura
    {
        private int _IdHakiArmadura;
        private string _EstadoHA;

        public HakiArmadura(int IdHakiArmadura, string EstadoHA)
        {
            _IdHakiArmadura = IdHakiArmadura;
            _EstadoHA = EstadoHA;
        }
        public  HakiArmadura()
        {}
        
        public int IdHakiArmadura
    {
        get{return _IdHakiArmadura;}
        set{_IdHakiArmadura=value;}
    }
        public string EstadoHA
    {
        get{return _EstadoHA;}
        set{_EstadoHA=value;}
    }
  }
}