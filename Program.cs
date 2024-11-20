// TODO: Realizar os testes com as classes Nokia e Iphone
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", IMEI: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");
Console.WriteLine("Smartphone Iphone:");

Smartphone iphone = new Nokia(numero: "654321", modelo: "Modelo 2", IMEI: "222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
