
using BuiderParameter;

var ms = new MailService();
ms.SendEmail(email => 
    email.To("FJKSL").From("fsfsd"));




public class Email
{
    public string From, To, Subject, Body;
    // other members here
}