namespace NotificationFactory.Notifications;

public class Push: Notification
{
    
    public string IpAddress { get; set; } // тут нужна проверка на корректность
    
        public override bool Send()
        {
            bool result = false;
            // лопика отправки push
            return result;
        }
    
}