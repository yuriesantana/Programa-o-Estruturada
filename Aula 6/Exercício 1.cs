int anonascimento, anoatual, idadeatual;
Console.WriteLine("Digite seu ano de nascimento:");
anonascimento = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o ano atual:");
anoatual = Convert.ToInt32(Console.ReadLine());
idadeatual = anoatual - anonascimento;
Console.WriteLine("Sua idade é:" + idadeatual);
