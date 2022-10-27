using System;
namespace PaginaOnePiece
{
    public class Personaje
 {
    private int _IdPersonaje;
    private string _NombrePersonaje;
    private string _InfoPersonaje;
    private int _IdMar;
   private int _IdRaza;
   private string _Foto;
 
    public Personaje(int IdPersonaje, string NombrePersonaje, string InfoPersonaje, int IdMar, int IdRaza, string Foto)
    {
      _IdPersonaje=IdPersonaje;
      _NombrePersonaje=NombrePersonaje;
      _InfoPersonaje=InfoPersonaje;
      _IdRaza = IdRaza;
      _Foto=Foto;
    }
    public Personaje()
    {}

    public int IdPersonaje
    {
        get{return _IdPersonaje;}
        set{_IdPersonaje=value;}
    }
      public string NombrePersonaje
    {
        get{return _NombrePersonaje;}
        set{_NombrePersonaje=value;}
    }
      public string InfoPersonaje
    {
        get{return _InfoPersonaje;}
        set{_InfoPersonaje=value;}
    }
      public int IdMar
    {
        get{return _IdMar;}
        set{_IdMar=value;}
    }
        public int IdRaza
    {
        get{return _IdRaza;}
        set{_IdRaza=value;}
    }
        public string Foto
    {
        get{return _Foto;}
        set{_Foto=value;}
    }
 }

}


