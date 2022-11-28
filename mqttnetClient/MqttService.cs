using MQTTnet;
using MQTTnet.Client;

public class MqttService
{
    IMqttClient mqttClient;

    public async Task Start(string brokerIp, string clientId, Action<string> callback = null)
    {
        var factory = new MqttFactory();

        var options = new MqttClientOptionsBuilder()
        .WithTcpServer(brokerIp)
        .WithClientId(clientId)
        .Build();

        mqttClient = factory.CreateMqttClient();
        await mqttClient.ConnectAsync(options, CancellationToken.None);
        await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic("MyTopic/test").Build());


        mqttClient.PublishStringAsync("MyTopic/test");

        //await mqttClient.ConnectAsync(options, CancellationToken.None);
    }

    
    //public async Task SendCode(string message)
    //{
        
    //    await mqttClient.PublishAsync("MyTopic/test", message);
        
    //}
}
