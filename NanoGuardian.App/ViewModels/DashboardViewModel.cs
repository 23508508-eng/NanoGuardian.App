using CommunityToolkit.Mvvm.ComponentModel;
using NanoGuardian.App.Models;

namespace NanoGuardian.App.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    // La etiqueta [ObservableProperty] avisa a la pantalla automáticamente si el dato cambia
    [ObservableProperty]
    private Alerta alertaActual;

    public DashboardViewModel()
    {
        // Datos simulados por hoy
        AlertaActual = new Alerta
        {
            Paciente = "Juan Hernandez", // Nota: Tu documento menciona más abajo "Juan Hernandez", puedes cambiarlo aquí si lo prefieres
            FuerzaImpactoG = 4,
            Estado = "Monitoreando..."
        };
    }
}
