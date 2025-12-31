# Hand-on — Alterações no projeto DesafioFundamentos

**Resumo:**
- **Projeto:** Exemplo simples de estacionamento em C#.
- **Alteração principal:** formatação de `valorTotal` para moeda brasileira (`pt-BR`).

**O que foi acrescentado**
- Inclusão do `using System.Globalization;` em `Estacionamento.cs`.
- Substituição da saída original que exibia o valor como texto com `R$ {valorTotal}` para usar `valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))`, garantindo formatação correta (símbolo, separador de milhares e decimal conforme locale).

**Arquivo alterado**
- [DesafioFundamentos/Models/Estacionamento.cs](DesafioFundamentos/Models/Estacionamento.cs)

**Trecho antes / depois**

Antes:

```csharp
Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
```

Depois:

```csharp
Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: {valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
```

**Motivação**
- Usar `ToString("C", CultureInfo.GetCultureInfo("pt-BR"))` assegura que valores monetários apareçam no formato local correto (ex.: `R$ 8,50`).
- Evita problemas com separador decimal (ponto vs vírgula) e posicionamento do símbolo.

**Como testar localmente**

1. Abra o terminal na pasta `DesafioFundamentos`.
2. Execute:

```bash
dotnet run
```

3. Digite valores para `precoInicial` e `precoPorHora`, cadastre um veículo (opção `1`), remova-o (opção `2`) e informe horas.

Exemplo de saída esperada:

```
O veículo ABC-1234 foi removido e o preço total foi de: R$ 8,50
```

**Observações / próximas melhorias sugeridas**
- Validar entradas do usuário (evitar exceções em conversões com `Convert.ToInt32` e `Convert.ToDecimal`).
- Normalizar placas ao armazenar (por exemplo, `Trim()` e `ToUpper()`), para evitar duplicatas ou falhas em comparações.
- Persistência simples (arquivo/texto) caso queira manter dados entre execuções.

---
Arquivo gerado automaticamente pelo assistente — quer que eu rode o `dotnet run` agora para verificar a saída?