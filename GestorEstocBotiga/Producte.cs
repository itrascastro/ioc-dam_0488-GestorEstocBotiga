namespace GestorEstocBotiga;

/// <summary>
/// Representa un producte de la botiga amb el seu estoc actual.
/// </summary>
public class Producte
{
    public string Nom { get; set; } = string.Empty;
    public int CapacitatMaxima { get; set; }
    public int Estoc { get; set; }
    public string Proveidor { get; set; } = string.Empty;

    public override string ToString() => Nom;
}
