int dividendo, divisor, quociente, resto;
Console.WriteLine("Digite o valor do dividendo:");
dividendo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor do divisor:");
divisor = Convert.ToInt32(Console.ReadLine());
quociente = dividendo / divisor;
resto = dividendo - (quociente * divisor);
Console.WriteLine("O resultado dessa divisão é:" + quociente + " e o resto:" + resto);
