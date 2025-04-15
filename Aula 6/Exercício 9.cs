//Exerício que calcula o IMC
double peso, imc, alt;
Console.WriteLine("Digite o seu peso:");
peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o seu altura em metros:");
alt = Convert.ToDouble(Console.ReadLine());
imc = peso / Math.Pow(alt, 2);
Console.WriteLine("seu IMC é:" + imc);
