using System;

namespace PaginaOnePiece
{
    public class Foro
    {
        private int _IdMensaje;
        private string _TextoMensaje;
        private DateTime _FechaMensaje;
        private int _IdUsuario;

        public Foro(int IdMensaje, string TextoMensaje, DateTime FechaMensaje, int IdUsuario)
        {
            _IdMensaje = IdMensaje;
            _TextoMensaje = TextoMensaje;
            _FechaMensaje = FechaMensaje;
            _IdUsuario = IdUsuario;
        }
        public Foro()
        {
        }

        public int IdMensaje
    {
        get{return _IdMensaje;}
        set{_IdMensaje=value;}
    }
        public string TextoMensaje
    {
        get{return _TextoMensaje;}
        set{_TextoMensaje=value;}
    }
        public DateTime FechaMensaje
    {
        get{return _FechaMensaje;}
        set{_FechaMensaje=value;}
    }
        public int IdUsuario
    {
        get{return _IdUsuario;}
        set{_IdUsuario=value;}
    }
  }

}