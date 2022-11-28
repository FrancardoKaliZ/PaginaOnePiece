using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaOnePiece.Models
{
    public class Bando
    {
       private int _IdBando ;
        private string _NombreBando;

        public Bando(int IdBando,string NombreBando)
        {
            _IdBando = IdBando;
            _NombreBando = NombreBando;
        }

        public Bando()
        {}

        public int IdBando
    {
        get{return _IdBando;}
        set{_IdBando=value;}
    }
        public string NombreBando
    {
        get{return _NombreBando;}
        set{_NombreBando=value;}
    }  
    }
}