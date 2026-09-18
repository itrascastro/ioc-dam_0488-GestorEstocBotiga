namespace GestorEstocBotiga;

/// <summary>
/// Encapsula la lectura i escriptura de la llista de productes en un fitxer de text pla.
/// </summary>
public class ProducteRepository
{
    /// <summary>
    /// Carrega els productes del fitxer indicat. Retorna una llista buida si el fitxer
    /// no existeix, ignora les línies buides i les línies que no tinguin exactament
    /// quatre camps.
    /// </summary>
    public List<Producte> Carrega(string ruta)
    {
        if (!File.Exists(ruta)) return new List<Producte>();

        var resultat = new List<Producte>();
        foreach (var linia in File.ReadAllLines(ruta, System.Text.Encoding.UTF8))
        {
            if (string.IsNullOrWhiteSpace(linia)) continue;

            var camps = linia.Split('|');
            if (camps.Length != 4) continue;
            if (!int.TryParse(camps[1], out int capacitat)) continue;
            if (!int.TryParse(camps[2], out int estoc)) continue;

            resultat.Add(new Producte
            {
                Nom = camps[0],
                CapacitatMaxima = capacitat,
                Estoc = estoc,
                Proveidor = camps[3]
            });
        }
        return resultat;
    }

    /// <summary>
    /// Desa la llista de productes al fitxer indicat, en format UTF-8.
    /// </summary>
    public void Desa(string ruta, IEnumerable<Producte> productes)
    {
        var linies = productes.Select(p => $"{p.Nom}|{p.CapacitatMaxima}|{p.Estoc}|{p.Proveidor}");
        File.WriteAllLines(ruta, linies, System.Text.Encoding.UTF8);
    }
}
