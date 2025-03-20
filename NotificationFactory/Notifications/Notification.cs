namespace NotificationFactory.Notifications;

public abstract class Notification
{
    protected string Header { get; set; }
    protected string Body { get; set; }

    public Notification(string body, string header = "")
    {
        Header = header;
        Body = body;
    }
    public abstract bool Send();
    
}