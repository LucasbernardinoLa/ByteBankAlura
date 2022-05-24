using ByteBank.Modelos;


int[] idades = new int[] { 15, 28, 35, 50, 28 };

int sum = 0;

for (int i = 0; i < idades.Length; i++)
{
    int idade = idades[i];
    Console.WriteLine($"Valor do índice {i}: {idade}");

    sum += idade;
}

int media = sum / idades.Length;
Console.WriteLine(media);