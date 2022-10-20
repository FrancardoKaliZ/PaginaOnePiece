using System;
namespace PaginaOnePiece
{
    public class Usuario
 {
    private int _IDUsuario;
    private string _NombreUsuario;
    private string _InfoUsuario;
    private string _Foto;
    private string _Contraseña;

    public Usuario(int IDUsuario, string NombreUsuario, string InfoUsuario, string Foto, string Contraseña)
    {
      _IDUsuario=IDUsuario;
      _NombreUsuario=NombreUsuario;
      _InfoUsuario=InfoUsuario;
      _Foto=Foto;
      _Contraseña = Contraseña;
    }
    public Usuario()
    {}

    public int IDUsuario
    {
        get{return _IDUsuario;}
        set{_IDUsuario=value;}
    }
    
    public string NombreUsuario
    {
        get{return _NombreUsuario;}
        set{_NombreUsuario=value;}
    }
    public string InfoUsuario
    {
        get{return _InfoUsuario;}
        set{_InfoUsuario=value;}
    }

    public string Foto
    {
        get{return _Foto;}
        set{_Foto=value;}
    }
        public string Contraseña
    {
        get{return _Contraseña;}
        set{_Contraseña=value;}
    }
 }

}


