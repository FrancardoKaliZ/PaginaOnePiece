using System;
namespace PaginaOnePiece
{
    public class PersonajeXTemporada
    {
       private int _IdPersonaje;
       private int _IdTemporada;
       private int _IdBando;
       private int _IdHakiArmadura;
       private int _IdHakiObservacion;
       private int _IdHakiRey;
       private int _IdTripulacion;
       private int _Recompensa;

       public string NombrePersonaje{get;set;}
       public string InfoPersonaje{get;set;}
       public string EstadoHA{get;set;}
       public string EstadoHO{get;set;}
       public string EstadoHR{get;set;}
       public string NombreBando{get;set;}
       public string NombreTripulacion{get;set;}


    public PersonajeXTemporada(int IdPersonaje, int IdTemporada, int IdBando, int IdHakiArmadura, int IdHakiObservacion, int IdHakiRey, int IdTripulacion, int Recompensa) 
       {
        _IdPersonaje = IdPersonaje;
        _IdTemporada = IdTemporada;
        _IdBando = IdBando;
        _IdHakiArmadura = IdHakiArmadura;
        _IdHakiObservacion = IdHakiObservacion;
        _IdHakiRey = IdHakiRey;
        _IdTripulacion = IdTripulacion;
        _Recompensa = Recompensa;
       }
    public PersonajeXTemporada()
        {}
    public int IdPersonaje
    {
        get{return _IdPersonaje;}
        set{_IdPersonaje=value;}
    }
    public int IdTemporada
    {
        get{return _IdTemporada;}
        set{_IdTemporada=value;}
    }
    public int IdBando
    {
        get{return _IdBando;}
        set{_IdBando=value;}
    }
    public int IdHakiArmadura
    {
        get{return _IdHakiArmadura;}
        set{_IdHakiArmadura=value;}
    }
    public int IdHakiObservacion
    {
        get{return _IdHakiObservacion;}
        set{_IdHakiObservacion=value;}
    }
    public int IdHakiRey
    {
        get{return _IdHakiRey;}
        set{_IdHakiRey=value;}
    }
    public int IdTripulacion
    {
        get{return _IdTripulacion;}
        set{_IdTripulacion=value;}
    }
    public int Recompensa
    {
        get{return _Recompensa;}
        set{_Recompensa=value;}
    }


    }
}