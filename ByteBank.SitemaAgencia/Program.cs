using ByteBank.Modelos;
using System.Text.RegularExpressions;

string padrao = "[0-9]{4,5}-?[0-9]{4}";
string texto = "Meu número é: 2342-3453";

Match match = Regex.Match(texto, padrao);
Console.WriteLine(match.Value);