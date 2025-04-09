int anos, dias, meses, resto;
Console.WriteLine("digite sua idade me dias:");
dias = Convert.ToInt32(Console.ReadLine());
anos = dias / 365;
resto = dias - (anos * 365);
meses = resto / 30;
dias = resto - (meses * 30);
Console.WriteLine("Sua idade em anos é:" + anos + " em meses:" +meses + " em dias:" +dias);