# gamer-profile-xunit

Projeto em C# que simula regras básicas de um perfil de jogador e demonstra testes unitários com xUnit.

## Propósito do sistema

A classe `PerfilJogadorService` (projeto `GamerProfile.App`) oferece três operações:

- `GerarTagUsuario(nickname, codigo)`: monta a tag do jogador no formato `Nickname#0000`.
- `CalcularXPTotal(xpFase1, xpFase2)`: soma o XP de duas fases e aplica um bônus fixo de 100 pontos.
- `EEligivelParaRanked(nivelJogador)`: informa se o jogador pode entrar em partidas ranqueadas (nível 15 ou maior).

## Testes unitários

O projeto `GamerProfile.Tests` contém três testes com `[Fact]`, um para cada tipo de retorno:

1. **string**: valida a formatação da tag com `Assert.Equal("Nickname#0000", resultado)`.
2. **int**: valida a soma das fases mais o bônus com `Assert.Equal(valorEsperado, resultado)`.
3. **bool**: valida a elegibilidade com `Assert.True` para níveis a partir de 15 e `Assert.False` para níveis abaixo de 15.

## Tecnologias

- .NET 10
- xUnit

## Como executar os testes

Na pasta da solução, execute:

```
dotnet test
```

## Licença

MIT
