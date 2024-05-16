# Desafio Explorando - Sistema de Reservas

Este projeto implementa um sistema de gerenciamento básico para reservas de suítes em um hotel fictício. O sistema permite criar reservas, cadastrar suítes e hóspedes, e calcular o valor total da diária considerando descontos para reservas de longa duração.

## Estrutura do Projeto

O projeto está organizado em várias classes dentro do namespace `DesafioExplorando.Models`:

### Classe `Suite`

- **Propriedades:**
  - `TipoSuite`: String que define o tipo da suíte (ex: Premium, Standard).
  - `Capacidade`: Inteiro que define o número máximo de hóspedes na suíte.
  - `ValorDiaria`: Decimal que define o custo diário da suíte.

### Classe `Pessoa`

- **Propriedades:**
  - `Nome`: String que contém o primeiro nome da pessoa.
  - `Sobrenome`: String que contém o sobrenome da pessoa.
  - `NomeCompleto`: Propriedade calculada que retorna o nome completo em maiúsculas.

### Classe `Reserva`

- **Propriedades:**
  - `Hospedes`: Lista de `Pessoa` que armazena os hóspedes da reserva.
  - `Suite`: Objeto `Suite` associado à reserva.
  - `DiasReservados`: Inteiro que representa a quantidade de dias da reserva.

- **Métodos:**
  - `CadastrarHospedes(List<Pessoa>)`: Registra os hóspedes e verifica a capacidade da suíte.
  - `CadastrarSuite(Suite)`: Associa uma suíte à reserva.
  - `ObterQuantidadeHospedes()`: Retorna o número de hóspedes na reserva.
  - `CalcularValorDiaria()`: Calcula o valor total da diária, aplicando desconto para reservas de 10 dias ou mais.

## Como Executar

1. Certifique-se de ter o .NET SDK instalado em seu sistema.
2. Navegue até o diretório do projeto e execute o comando `dotnet run` para iniciar a aplicação.
3. A saída no console mostrará o número de hóspedes e o valor total da diária calculada.

## Exemplo de Uso

No exemplo incluído no código principal (`Program.cs`), são criados dois hóspedes e uma suíte do tipo Premium com capacidade para 2 pessoas. Uma reserva é então feita para 10 dias, e o sistema calcula o valor total da diária com o desconto aplicado.

```csharp
// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
