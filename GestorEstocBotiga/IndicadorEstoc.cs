using System.ComponentModel;

namespace GestorEstocBotiga;

/// <summary>
/// Component visual reutilitzable que mostra l'estoc d'un producte com a percentatge,
/// amb un indicador de color segons l'estat.
/// </summary>
public partial class IndicadorEstoc : UserControl
{
    private int percentatgeEstoc;
    private string estatAnterior = string.Empty;

    public IndicadorEstoc()
    {
        InitializeComponent();
        ActualitzaAspecte();
    }

    /// <summary>
    /// Percentatge d'estoc actual, sempre entre 0 i 100. Els valors fora de rang
    /// es retallen automàticament (no es llança cap excepció).
    /// </summary>
    [Category("GestorEstoc")]
    [Description("Percentatge d'estoc del producte, entre 0 i 100.")]
    [DefaultValue(0)]
    public int PercentatgeEstoc
    {
        get => percentatgeEstoc;
        set
        {
            percentatgeEstoc = Math.Max(0, Math.Min(100, value));
            ActualitzaAspecte();
            ComprovaCanviEstat();
        }
    }

    /// <summary>
    /// Estat textual calculat a partir del percentatge d'estoc actual.
    /// </summary>
    [Browsable(false)]
    public string EstatEstoc
    {
        get
        {
            if (percentatgeEstoc < 20) return "Esgotat";
            if (percentatgeEstoc < 50) return "Estoc baix";
            return "Disponible";
        }
    }

    /// <summary>Es dispara quan l'estoc passa a l'estat "Disponible" (50 o més).</summary>
    public event EventHandler? EstocDisponible;

    /// <summary>Es dispara quan l'estoc passa a l'estat "Estoc baix" (entre 20 i 49).</summary>
    public event EventHandler? EstocBaix;

    /// <summary>Es dispara quan l'estoc passa a l'estat "Esgotat" (menys de 20).</summary>
    public event EventHandler? EstocEsgotat;

    protected virtual void OnEstocDisponible(EventArgs e) => EstocDisponible?.Invoke(this, e);
    protected virtual void OnEstocBaix(EventArgs e) => EstocBaix?.Invoke(this, e);
    protected virtual void OnEstocEsgotat(EventArgs e) => EstocEsgotat?.Invoke(this, e);

    /// <summary>
    /// Reaprovisiona el producte: posa l'estoc al 100% i actualitza la interfície.
    /// </summary>
    public void Reaprovisiona()
    {
        PercentatgeEstoc = 100;
    }

    private void ComprovaCanviEstat()
    {
        // Els esdeveniments només es llancen quan l'estat canvia, no en cada assignació.
        if (EstatEstoc == estatAnterior) return;
        estatAnterior = EstatEstoc;

        switch (EstatEstoc)
        {
            case "Disponible":
                OnEstocDisponible(EventArgs.Empty);
                break;
            case "Estoc baix":
                OnEstocBaix(EventArgs.Empty);
                break;
            case "Esgotat":
                OnEstocEsgotat(EventArgs.Empty);
                break;
        }
    }

    private void ActualitzaAspecte()
    {
        barraEstoc.Value = percentatgeEstoc;
        lblPercentatge.Text = $"{percentatgeEstoc} %";
        toolTipEstoc.SetToolTip(barraEstoc, $"Estoc exacte: {percentatgeEstoc} %");

        barraEstoc.ForeColor = EstatEstoc switch
        {
            "Disponible" => Color.SeaGreen,
            "Estoc baix" => Color.DarkOrange,
            _ => Color.Firebrick
        };
        iconaEstat.BackColor = barraEstoc.ForeColor;
    }
}
