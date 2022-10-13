using System;
namespace PaginaOnePiece
{
    public class Personaje
 {
    private int _idPersonaje;
    private string _NombrePersonaje;
    private string _InfoPersonaje;
    private int _idBando;
    private int _idMar;
    private int _Recompensa;
    private int _idTripulacion;
    private int _idHakiRey;
    private int _idHakiObservasion;
   private int _idHakiArmadura;
  private int _idRaza;
 
    public Personaje(int idPersonaje, string NombrePersonaje, string InfoPersonaje, int idBando, int idMar, int Recompensa,int idTripulacion, int idHakiRey, int idHakiObservasion, int idHakiArmadura, int idRaza)
    {
      _idPersonaje=idPersonaje;
      _NombrePersonaje=NombrePersonaje;
      _InfoPersonaje=InfoPersonaje;
      _idBando=idBando;
      _idMar=idMar;
      _Recompensa=Recompensa;
      _idTripulacion = idTripulacion;
      _idHakiRey = idHakiRey;
      _idHakiObservasion=idHakiObservasion;
      _idHakiArmadura=idHakiArmadura;
      _idRaza = idRaza;
    }
    public Personaje()
    {}

    public int idPersonaje
    {
        get{return _idPersonaje;}
        set{_idPersonaje=value;}
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
      public int idBando
    {
        get{return _idBando;}
        set{_idBando=value;}
    }
      public int idMar
    {
        get{return _idBando;}
        set{_idBando=value;}
    }
      public int Recompensa
    {
        get{return _Recompensa;}
        set{_Recompensa=value;}
    }
       public int idTripulacion
    {
        get{return _idTripulacion;}
        set{_idTripulacion=value;}
    }

      public int idHakiRey
    {
        get{return _idHakiRey;}
        set{_idHakiRey=value;}
    }

       public int idHakiObservasion    
    {
        get{return _idHakiObservasion;}
        set{_idHakiObservasion=value;}
    }

     public int idHakiArmadura
    {
        get{return _idHakiArmadura;}
        set{_idHakiArmadura=value;}
    }

          public int idRaza
    {
        get{return _idRaza;}
        set{_idRaza=value;}
    }
 }

}


