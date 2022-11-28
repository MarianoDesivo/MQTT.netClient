// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
MqttService mqttService = new MqttService();
await mqttService.Start("localhost", "123");
Console.ReadLine();