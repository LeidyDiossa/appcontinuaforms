using System;
    class Docentes:Personas
    {
        private string memo;

    public Docentes(string memo, string ocupacion_est, string nom, string ape, string tel, string direc, string ema, string cel, string ep, string tipo) : base(nom, ape, tel, direc, ema, cel, ep, tipo)
    {
        this.memo = memo;
    }
}
    
