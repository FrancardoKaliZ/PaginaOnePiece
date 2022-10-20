using System;
namespace PaginaOnePiece
{
    public class Temporada
 {
    private int _IdTemporada;
    private int _IdMar;

    private string _NombreTemporada;
   
   private DateTime _FechaInicio;
    private DateTime _FechaFin;

     private string _InfoTemporada;

      private int _Capitulos;
 
    public Temporada(int IdTemporada, int IdMar, string NombreTemporada, DateTime FechaInicio, DateTime FechaFin, string InfoTemporada, int Capitulos)
    {
      _IdTemporada=IdTemporada;
      _IdMar=IdMar;
      _NombreTemporada=NombreTemporada;
      _FechaInicio=FechaInicio;
      _FechaFin=FechaFin;
      _InfoTemporada=InfoTemporada;
      _Capitulos=Capitulos;
    }
    public Temporada()
    {}

    public int IdTemporada
    {
        get{return _IdTemporada;}
        set{_IdTemporada=value;}
    }
 
    public int IdMar
    {
        get{return _IdMar;}
        set{_IdMar=value;}
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


