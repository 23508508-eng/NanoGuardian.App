namespace NanoGuardian.App.Models;

public class Alerta
{
    public string Paciente { get; set; } = string.Empty;
    public int FuerzaImpactoG { get; set; }
    public string Estado { get; set; } = string.Empty;
}//Forzando el pull Request desde la web
