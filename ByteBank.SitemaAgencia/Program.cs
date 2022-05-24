using ByteBank.Modelos;
using ByteBank.SitemaAgencia.Extensoes;

var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 999),
                null,
                new ContaCorrente(340, 4),
                new ContaCorrente(340, 456),
                new ContaCorrente(340, 10),
                null,
                null,
                new ContaCorrente(290, 123)
            };



var contasOrdenadas = contas
    .Where(conta => conta != null)
    .OrderBy(conta => conta.Numero);

foreach (var conta in contasOrdenadas)
{
    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
}


Console.ReadLine();
        







