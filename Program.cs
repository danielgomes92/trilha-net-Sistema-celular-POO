using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia"); //Alterar modelo

Smartphone nokia = new Nokia(numero: "45678900", modelo: "moto g", imei: "2020301030", memoria: 128);
nokia.Ligar();
//nokia.ReceberLigacao();
nokia.InstalarAplicativo("BrainStorm");

Smartphone iphone = new Iphone(numero: "00987654", modelo: "iphone X", imei: "3040401015", memoria: 64);
iphone.Ligar();
//iphone.ReceberLigacao();
iphone.InstalarAplicativo("DuoLingo");