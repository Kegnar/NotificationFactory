namespace NotificationFactory.Notifications;

public class Sms : Notification
{
    public string Number { get; set; } // тут прописать проверку номера на валидность
    
    public override bool Send()
    {
        bool result = false;
        // лопика отправки SMS
        return result;
    }
}