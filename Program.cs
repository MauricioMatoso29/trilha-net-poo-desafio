using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo 1", imei: "11111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Iphone(numero: "321", modelo: "Modelo 3", imei: "33333", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Uber");
iphone.DesinstalarAplicativo("Instagram");