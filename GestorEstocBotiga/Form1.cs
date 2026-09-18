using System.ComponentModel;

namespace GestorEstocBotiga;

public partial class Form1 : Form
{
    private readonly ProducteRepository repositori = new();
    private readonly BindingList<Producte> productes = new();
    private readonly string rutaFitxer = Path.Combine(AppContext.BaseDirectory, "productes.txt");

    public Form1()
    {
        InitializeComponent();

        dgvProductes.AutoGenerateColumns = true;
        dgvProductes.DataSource = productes;

        indicadorEstoc1.EstocDisponible += (s, e) => lblEstatGeneral.Text = "Estat: estoc disponible";
        indicadorEstoc1.EstocBaix += (s, e) => lblEstatGeneral.Text = "Estat: estoc baix, cal revisar";
        indicadorEstoc1.EstocEsgotat += (s, e) => lblEstatGeneral.Text = "Estat: producte esgotat";

        CarregaProductes();
    }

    private void CarregaProductes()
    {
        productes.Clear();
        foreach (var p in repositori.Carrega(rutaFitxer))
        {
            productes.Add(p);
        }

        if (productes.Count > 0)
        {
            dgvProductes.ClearSelection();
            dgvProductes.Rows[0].Selected = true;
        }
    }

    private void DgvProductes_SelectionChanged(object? sender, EventArgs e)
    {
        var seleccionat = ProducteSeleccionat();
        if (seleccionat is null)
        {
            lblNomProducte.Text = "(cap producte seleccionat)";
            indicadorEstoc1.PercentatgeEstoc = 0;
            return;
        }

        lblNomProducte.Text = seleccionat.Nom;

        int percentatge = seleccionat.CapacitatMaxima > 0
            ? seleccionat.Estoc * 100 / seleccionat.CapacitatMaxima
            : 0;

        indicadorEstoc1.PercentatgeEstoc = percentatge;

        nudEstoc.ValueChanged -= NudEstoc_ValueChanged;
        nudEstoc.Value = Math.Min(nudEstoc.Maximum, seleccionat.Estoc);
        nudEstoc.ValueChanged += NudEstoc_ValueChanged;
    }

    private void NudEstoc_ValueChanged(object? sender, EventArgs e)
    {
        var seleccionat = ProducteSeleccionat();
        if (seleccionat is null) return;

        seleccionat.Estoc = (int)nudEstoc.Value;

        int percentatge = seleccionat.CapacitatMaxima > 0
            ? seleccionat.Estoc * 100 / seleccionat.CapacitatMaxima
            : 0;

        indicadorEstoc1.PercentatgeEstoc = percentatge;
        dgvProductes.Refresh();
    }

    private void BtnReaprovisiona_Click(object? sender, EventArgs e)
    {
        var seleccionat = ProducteSeleccionat();
        if (seleccionat is null) return;

        seleccionat.Estoc = seleccionat.CapacitatMaxima;
        indicadorEstoc1.Reaprovisiona();

        nudEstoc.ValueChanged -= NudEstoc_ValueChanged;
        nudEstoc.Value = Math.Min(nudEstoc.Maximum, seleccionat.Estoc);
        nudEstoc.ValueChanged += NudEstoc_ValueChanged;

        dgvProductes.Refresh();
    }

    private void BtnDesa_Click(object? sender, EventArgs e)
    {
        repositori.Desa(rutaFitxer, productes);
        MessageBox.Show("Productes desats correctament.", "Desar");
    }

    private void MenuSortir_Click(object? sender, EventArgs e)
    {
        Application.Exit();
    }

    private void MenuQuantA_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("GestorEstocBotiga - Exemple de la Unitat 1.", "Quant a");
    }

    private Producte? ProducteSeleccionat()
    {
        if (dgvProductes.CurrentRow?.DataBoundItem is Producte producte) return producte;
        return null;
    }
}
