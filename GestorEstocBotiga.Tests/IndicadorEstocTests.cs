using GestorEstocBotiga;

namespace GestorEstocBotiga.Tests;

public class IndicadorEstocTests
{
    [Fact]
    public void PercentatgeNegatiu_EsRetallaAZero()
    {
        var indicador = new IndicadorEstoc();
        indicador.PercentatgeEstoc = -15;
        Assert.Equal(0, indicador.PercentatgeEstoc);
    }

    [Fact]
    public void PercentatgeSuperiorA100_EsRetallaA100()
    {
        var indicador = new IndicadorEstoc();
        indicador.PercentatgeEstoc = 150;
        Assert.Equal(100, indicador.PercentatgeEstoc);
    }

    [Theory]
    [InlineData(0, "Esgotat")]
    [InlineData(19, "Esgotat")]
    [InlineData(20, "Estoc baix")]
    [InlineData(49, "Estoc baix")]
    [InlineData(50, "Disponible")]
    [InlineData(100, "Disponible")]
    public void EstatEstoc_CorresponAlPercentatge(int percentatge, string estatEsperat)
    {
        var indicador = new IndicadorEstoc { PercentatgeEstoc = percentatge };
        Assert.Equal(estatEsperat, indicador.EstatEstoc);
    }

    [Fact]
    public void Reaprovisiona_DeixaElPercentatgeAlCent()
    {
        var indicador = new IndicadorEstoc();
        indicador.PercentatgeEstoc = 10;
        indicador.Reaprovisiona();
        Assert.Equal(100, indicador.PercentatgeEstoc);
    }

    [Fact]
    public void EstocBaix_NomesEsLlancaUnCopEnCanviarDEstat()
    {
        var indicador = new IndicadorEstoc();
        int vegadesLlancat = 0;
        indicador.EstocBaix += (s, e) => vegadesLlancat++;

        indicador.PercentatgeEstoc = 30; // entra a "Estoc baix": es dispara
        indicador.PercentatgeEstoc = 35; // continua a "Estoc baix": NO s'ha de tornar a disparar
        indicador.PercentatgeEstoc = 40; // continua a "Estoc baix": tampoc

        Assert.Equal(1, vegadesLlancat);
    }

    [Fact]
    public void EstocEsgotat_EsDisparaEnEntrarAAquestEstat()
    {
        var indicador = new IndicadorEstoc();
        bool disparat = false;
        indicador.EstocEsgotat += (s, e) => disparat = true;

        indicador.PercentatgeEstoc = 60; // Disponible
        indicador.PercentatgeEstoc = 5;  // Esgotat: aquí sí s'ha de disparar

        Assert.True(disparat);
    }
}
