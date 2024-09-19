namespace FIAP.Consumer.Services;

public interface INotificationService
{
    void NotifyUser(int FromId, int ToId, string Content);
}
