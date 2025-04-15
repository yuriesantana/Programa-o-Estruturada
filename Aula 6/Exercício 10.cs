//Exerício que calcula juros simples
double jurosimp, taxajuros, tempo, capital;
Console.WriteLine("Digite o capital inicial:");
capital = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a taxa de juros:");
taxajuros = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o tempo:");
tempo = Convert.ToDouble(Console.ReadLine());
jurosimp = capital * (taxajuros / 100) * tempo;
Console.WriteLine("O valor do juros será:" + jurosimp);
