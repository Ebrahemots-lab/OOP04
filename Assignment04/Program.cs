using Assignment04.Question03;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            // What is the primary purpose of an interface in C#?
            //Answer : a
            #endregion

            #region 02
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //answer : a - b - c 
            #endregion

            #region 03
            //Can an interface contain fields in C#?
            // b
            #endregion

            #region 04
            //In C#, can an interface inherit from another interface?
            // b 
            #endregion

            #region 05
            //Which keyword is used to implement an interface in a class in C#?
            //d
            #endregion

            #region 06
            //Can an interface contain static methods in C#?
            //b

            #endregion

            #region 07
            //In C#, can an interface have explicit access modifiers for its members?
            //b
            #endregion

            #region 08
            //What is the purpose of an explicit interface implementation in C#?
            //d
            #endregion

            #region 09
            //In C#, can an interface have a constructor?
            //b

            #endregion

            #region 10
            //How can a C# class implement multiple interfaces?
            //a

            #endregion

            //Part02
            #region Question 01
            //Circle c1 = new Circle() { Area = 100};
            //c1.DisplayShapeInfo();

            //Rectangle r1 = new Rectangle() { Area = 200}; 
            //r1.DisplayShapeInfo();
            #endregion

            #region Question 02

            //Stored Creditntial
            

            User use1 = new User() { UserName = "Admin", Password = "123" , Role = Role.User};

            BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService();

            //bool authenticationStatus = basicAuthenticationService.AuthenticatteUser(use1);

            //bool authorizedAuser = basicAuthenticationService.AuthorizeUser(use1);

            //Console.WriteLine(authorizedAuser);

            //Console.WriteLine(authenticationStatus);

            IAuthenticationService authenticationService = new BasicAuthenticationService();

            Console.WriteLine(authenticationService.AuthenticatteUser(use1));

            Console.WriteLine(authenticationService.AuthorizeUser(use1));

            #endregion

            #region 03
            EmailNotificationService email = new EmailNotificationService();
            email.SendNotification("Ebrahem", "Hello from mail");

            PushNotificationService notification = new PushNotificationService();
            notification.SendNotification("Ahmed","Hello from notifitcaion");

            SmsNotificationService sms = new SmsNotificationService();
            sms.SendNotification("Ots", "Hello from sms");
            #endregion

        }
    }
}
