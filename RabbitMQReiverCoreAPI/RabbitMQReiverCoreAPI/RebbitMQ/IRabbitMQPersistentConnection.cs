namespace RabbitMQReiverCoreAPI.RebbitMQ
{
    using System;
    using RabbitMQ.Client;

    public interface IRabbitMQPersistentConnection : IDisposable
    {
        bool IsConnected { get; }

        bool TryConnect();

        IModel CreateModel();

        void CreateConsumerChannel();

        void Disconnect();
    }
}
