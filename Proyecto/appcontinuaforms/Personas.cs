using System;
public class Personas
{
    public string nombres { get; set; }
    public string apellidos { get; set; }
    public string telefono { get; set; }
    public string direccion { get; set; }
    public string email { get; set; }
    public string celular { get; set; }
    public string eps { get; set; }
    public string tipo_persona { get; set; }


    //constructor
    public Personas(string nom, string ape, string tel, string direc, string ema, string cel, string ep, string tipo)
    {
        this.nombres = nom;
        this.apellidos = ape;
        this.telefono = tel;
        this.direccion = direc;
        this.email = ema;
        this.celular = cel;
        this.eps = ep;
        this.tipo_persona = tipo;
    }



}

