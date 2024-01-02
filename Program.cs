using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("5461-9862", "AMIRES-2.5", "1111111111", 64);
Iphone iphone = new Iphone("6413-5267", "MALJFE-21", "222222222", 124);

nokia.Ligar();
Console.WriteLine("--------------");
nokia.ReceberLigacao();
Console.WriteLine("--------------------");
nokia.InstalarAplicativo("Telegram");

iphone.Ligar();
Console.WriteLine("--------------");
iphone.ReceberLigacao();
Console.WriteLine("--------------");
iphone.InstalarAplicativo("Whatsapp");