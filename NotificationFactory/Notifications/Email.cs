namespace NotificationFactory.Notifications;

public class Email : Notification
{
    public string EmailAddress { get; set; }

    public override bool Send()
    {
        bool result = false;
        // логика отправки почты
        return result;
    }
}