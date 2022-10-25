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
 
    public Personaje(int IdPersonaje, string NombrePersonaje, string InfoPersonaje, int IdMar, int IdRaza)
    {
      _IdPersonaje=IdPersonaje;
      _NombrePersonaje=NombrePersonaje;
      _InfoPersonaje=InfoPersonaje;
      _IdRaza = IdRaza;
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
 }

}


