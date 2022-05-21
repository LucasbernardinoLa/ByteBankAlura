using ByteBank.Modelos;
using Humanizer;


// Dia 17 de Agosto de 2018
DateTime dataFimPagamento = new DateTime(2022, 5, 22);
// Data corrente no momento de execução do código
DateTime dataCorrente = DateTime.Now;
TimeSpan diferenca = dataFimPagamento - dataCorrente;

string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

Console.WriteLine(mensagem);