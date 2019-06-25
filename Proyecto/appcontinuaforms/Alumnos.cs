using System;
class Alumnos : Personas
{
    private string ocupacion_est;


    //constructor 
    public Alumnos(string ocupacion_est, string nom, string ape, string tel, string direc, string ema, string cel, string ep, string tipo):base(nom,ape,tel,direc,ema,cel,ep,tipo)
    {
        this.ocupacion_est = ocupacion_est;
    }
}



