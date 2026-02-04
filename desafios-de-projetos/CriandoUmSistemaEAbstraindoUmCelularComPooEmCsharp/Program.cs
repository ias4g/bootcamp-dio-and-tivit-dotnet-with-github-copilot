using CriandoUmSistemaEAbstraindoUmCelularComPooEmCsharp.Model;

Console.WriteLine("\nSmartphone Nokia!");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 01", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n-------------------------------------------\n");

Console.WriteLine("Smartphone Iphone!");
Smartphone iphone = new Iphone(numero: "7987", modelo: "Modelo 02", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");