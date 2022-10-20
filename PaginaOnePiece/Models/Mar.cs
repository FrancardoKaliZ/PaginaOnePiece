using System;
namespace PaginaOnePiece
{
    public class Mar
    {
        private int _IdMar;
        private string _NombreMar;
        private string _InfoMar;
    
    public Mar(int IdMar,string NombreMar, string InfoMar)
    {
        _IdMar = IdMar;
        _NombreMar = NombreMar;
        _InfoMar = InfoMar;
    }
    public Mar()
    {}
    public int IdMar
    {
        get{return _IdMar;}
        set{_IdMar=value;}
    }
    public string NombreMar
    {
        get{return _NombreMar;}
        set{_NombreMar=value;}
    }
    public string InfoMar
    {
        get{return _InfoMar;}
        set{_InfoMar=value;}
    }
 }
}