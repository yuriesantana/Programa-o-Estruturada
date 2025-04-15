//Exerício que calcula a hipotenusa de um triangulo retangulo
double cateto1, cateto2, hipotenusa;
Console.WriteLine("Digite o valor do primeiro cateto:");
cateto1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o valor do segundo cateto:");
cateto2 = Convert.ToDouble(Console.ReadLine());
hipotenusa = Math.Sqrt(cateto1*cateto1 + cateto2*cateto2);
Console.WriteLine("A hipotenusa é:" + hipotenusa);
