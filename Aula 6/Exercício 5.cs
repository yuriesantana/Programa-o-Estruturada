double valordolar, valorreais, cotacao;
Console.WriteLine("Digite o valor em reais:");
valorreais = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o valor da cotação do dólar:");
valordolar = Convert.ToDouble(Console.ReadLine());
cotacao = valorreais / valordolar;
Console.WriteLine("O valor de dolares dessa quantia é:" + cotacao);