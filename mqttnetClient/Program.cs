// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
MqttService mqttService = new MqttService();
await mqttService.Start("10.10.10.156", "123");
Console.ReadLine();