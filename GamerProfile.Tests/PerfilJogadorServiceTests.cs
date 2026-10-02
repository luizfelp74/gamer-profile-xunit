using GamerProfile.App;
using Xunit;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    [Fact]
    public void GerarTagUsuario_DeveConcatenarNicknameECodigoComHash()
    {
        var service = new PerfilJogadorService();

        var resultado = service.GerarTagUsuario("Nickname", "0000");

        Assert.Equal("Nickname#0000", resultado);
    }

    [Fact]
    public void CalcularXPTotal_DeveSomarFasesEAplicarBonusDe100()
    {
        var service = new PerfilJogadorService();
        var valorEsperado = 600;

        var resultado = service.CalcularXPTotal(200, 300);

        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void EEligivelParaRanked_DeveValidarRegraDoNivel15()
    {
        var service = new PerfilJogadorService();

        Assert.True(service.EEligivelParaRanked(15));
        Assert.True(service.EEligivelParaRanked(20));
        Assert.False(service.EEligivelParaRanked(14));
        Assert.False(service.EEligivelParaRanked(1));
    }
}
