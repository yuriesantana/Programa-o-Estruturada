//Exerício que calcula o volume de um cilindro
double volume, altura, raio;
Console.WriteLine("Digite o valor da altura:");
altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o valor do raio:");
raio = Convert.ToDouble(Console.ReadLine());
volume = 3 * raio * raio * altura;
Console.WriteLine("O volume do cilindro:" + volume);
