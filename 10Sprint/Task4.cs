interface INotification
    {
        void SendNotification();
    }
    interface INotificationToDB
    {
        void AddNotificationToDB();
    }
    interface INotificationToDBRead
    {
        void ReadNotification();
    }


    public class MailService : INotification, INotificationToDB, INotificationToDBRead
    {
        string Email { get; set; }

        string EmailTitle { get; set; }
        string EmailBody { get; set; }
        public MailService(string email, string emailbody, string emailtitle)
        {
            Email = email;
            EmailTitle = emailtitle;
            EmailBody = emailbody;
        }
        public void SendNotification()
        {
            Console.WriteLine($"Mail:{Email}, Title:{EmailTitle}, Body:{EmailBody}");
        }
        public bool ValidEmail()
        {
            return Email.Contains("@");
        }

        public void AddNotificationToDB()
        {

        }

        public void ReadNotification()
        {
            
        }
    }
    public class SmsService : INotification
    {
        string Number { get; set; }

        string SmsText { get; set; }
        public SmsService(string number, string smsText)
        {
            Number = number;
            SmsText = smsText;
        }
        public void SendNotification()
        {
            Console.WriteLine($"Number:{Number}, Message:{SmsText}");
        }
    }
    public class Customer
    {
        public static void Register(string email, string password)
        {
            MailService ms = new MailService(email, "Body of message...", "User registration");
            SmsService ss = new SmsService("111 111 111", "User successfully registered...");
            try
            {
                if (ms.ValidEmail())
                {
                    ms.SendNotification();
                    ms.AddNotificationToDB();
                    ms.ReadNotification();
                    ss.SendNotification();

                }
            }
            catch
            {
                throw;
            }
        }
    }
