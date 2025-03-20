namespace NotificationFactory.Notifications.Factory;

public class EmailFactory : NotificationFactory
{
    public override Notification Create()
    {
        return new Email();
    }
}