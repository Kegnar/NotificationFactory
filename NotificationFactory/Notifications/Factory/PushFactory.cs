namespace NotificationFactory.Notifications.Factory;

public class PushFactory : NotificationFactory
{
    public override Notification Create()
    {
        return new Push();  
    }
}

