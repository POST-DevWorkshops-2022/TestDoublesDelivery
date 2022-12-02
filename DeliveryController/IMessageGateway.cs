namespace DeliverySystem
{
    public interface IMessageGateway
    {
        void Send(string address, string subject, string message);
    }
}