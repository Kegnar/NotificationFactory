using System.Runtime.InteropServices.JavaScript;

namespace NotificationFactory.Notifications;

public class Sms : Notification
{
    public Sms(string body, string number) : base(body)
    {
        Number=number;
    }
    string Number { get; set; } // тут прописать проверку номера на валидность
    
    public override bool Send()
    {
        bool result = false;
        //логика отправки sms
            Console.WriteLine($"SMS с текстом \"{Body}\"на {Number} отправлена");
            result = true;

        return result;
    }
}