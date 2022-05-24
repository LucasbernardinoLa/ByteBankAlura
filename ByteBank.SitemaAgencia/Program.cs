using ByteBank.Modelos;
using ByteBank.SitemaAgencia.Extensoes;

List<int> idades = new List<int>();

idades.AdicionarVarios(39, 81, 1, 5, 14, 25, 38, 61);

idades.Sort();

for (int i = 0; i < idades.Count; i++)
{
    Console.WriteLine(idades[i]);
}









