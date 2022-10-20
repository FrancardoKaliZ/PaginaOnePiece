using System;
namespace PaginaOnePiece
{
    public class Personaje
 {
    private int _IdPersonaje;
    private string _NombrePersonaje;
    private string _InfoPersonaje;
    private int _IdBando;
    private int _IdMar;
    private int _Recompensa;
    private int _IdTripulacion;
    private int _IdHakiRey;
    private int _IdHakiObservasion;
   private int _IdHakiArmadura;
   private int _IdRaza;
 
    public Personaje(int IdPersonaje, string NombrePersonaje, string InfoPersonaje, int IdBando, int IdMar, int Recompensa,int IdTripulacion, int IdHakiRey, int IdHakiObservasion, int IdHakiArmadura, int IdRaza)
    {
      _IdPersonaje=IdPersonaje;
      _NombrePersonaje=NombrePersonaje;
      _InfoPersonaje=InfoPersonaje;
      _IdBando=IdBando;
      _IdMar=IdMar;
      _Recompensa=Recompensa;
      _IdTripulacion = IdTripulacion;
      _IdHakiRey = IdHakiRey;
      _IdHakiObservasion=IdHakiObservasion;
      _IdHakiArmadura=IdHakiArmadura;
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
      public int IdBando
    {
        get{return _IdBando;}
        set{_IdBando=value;}
    }
      public int IdMar
    {
        get{return _IdBando;}
        set{_IdBando=value;}
    }
      public int Recompensa
    {
        get{return _Recompensa;}
        set{_Recompensa=value;}
    }
       public int IdTripulacion
    {
        get{return _IdTripulacion;}
        set{_IdTripulacion=value;}
    }

      public int IdHakiRey
    {
        get{return _IdHakiRey;}
        set{_IdHakiRey=value;}
    }

       public int IdHakiObservasion    
    {
        get{return _IdHakiObservasion;}
        set{_IdHakiObservasion=value;}
    }

     public int IdHakiArmadura
    {
        get{return _IdHakiArmadura;}
        set{_IdHakiArmadura=value;}
    }

          public int IdRaza
    {
        get{return _IdRaza;}
        set{_IdRaza=value;}
    }
 }

}


