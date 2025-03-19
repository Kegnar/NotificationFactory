namespace NotificationFactory.Notifications;

public abstract class Notification
{
    public string Header { get; set; }
    public string Body { get; set; }
    public abstract bool Send();
    
}