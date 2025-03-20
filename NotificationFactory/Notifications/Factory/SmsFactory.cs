namespace NotificationFactory.Notifications.Factory;

public class SmsFactory:NotificationFactory
{
    public override Notification Create()
    {
        return new Sms();
    }
}