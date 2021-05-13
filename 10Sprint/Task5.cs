public interface INotification
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
        public string Email { get; set; }

        public string EmailTitle { get; set; }
        public string EmailBody { get; set; }
        
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
        public string Number { get; set; }

        public string SmsText { get; set; }
        
        public void SendNotification()
        {
            Console.WriteLine($"Number:{Number}, Message:{SmsText}");
        }
    }
    public class Customer
    {
        INotification Notification { get; set; }
        public Customer(INotification notification)
        {
            Notification = notification;
        }
        public void Register(string email, string password)
        {
            
            try
            {
                
            }
            catch
            {
               
            }
        }
        public void SendNotification(INotification notification)
        {
            notification.SendNotification();
        }
    }
