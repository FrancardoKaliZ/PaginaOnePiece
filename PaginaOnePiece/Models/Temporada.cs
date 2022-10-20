using System;
namespace PaginaOnePiece
{
    public class Temporada
 {
    private int _idTemporada;
    private int _idMar;

    private string _NombreTemporada;
   
   private DateTime _FechaInicio;
    private DateTime _FechaFin;

     private string _InfoTemporada;

      private int _Capitulos;
 
    public Temporada(int idTemporada, int idMar, string NombreTemporada, DateTime FechaInicio, DateTime FechaFin, string InfoTemporada, int Capitulos)
    {
      _idTemporada=idTemporada;
      _idMar=idMar;
      _NombreTemporada=NombreTemporada;
      _FechaInicio=FechaInicio;
      _FechaFin=FechaFin;
      _InfoTemporada=InfoTemporada;
      _Capitulos=Capitulos;
    }
    public Temporada()
    {}

    public int idTemporada
    {
        get{return _idTemporada;}
        set{_idTemporada=value;}
    }
 
    public int idMar
    {
        get{return _idMar;}
        set{_idMar=value;}
    }
    
    public string NombreTemporada
    {
        get{return _NombreTemporada;}
        set{_NombreTemporada=value;}
    }
    
    public DateTime FechaInicio
    {
        get{return _FechaInicio;}
        set{_FechaInicio=value;}
    }
    public DateTime FechaFin
    {
        get{return _FechaFin;}
        set{_FechaFin=value;}
    }
        public string InfoTemporada
    {
        get{return _InfoTemporada;}
        set{_InfoTemporada=value;}
    }
       public int Capitulos
    {
        get{return _Capitulos;}
        set{_Capitulos=value;}
    }
    
 }

}


