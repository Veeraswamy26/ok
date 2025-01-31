using System;
using System.Net;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        /*if (args.Length < 2)
        {
            Console.WriteLine("Usage: EmailSender.exe <subject> <body>");
            return;
        }

        string subject = args[0];  // Subject from command line
        string body = args[1];     // Body from command line
        */
        string subject = "HandleInheritability";  // Subject from command line
        string body = "isdgfios";
        Console.WriteLine($"EMAIL_USER: {Environment.GetEnvironmentVariable("EMAIL_USER", EnvironmentVariableTarget.User)}");
        Console.WriteLine($"EMAIL_PASS: {Environment.GetEnvironmentVariable("EMAIL_PASS", EnvironmentVariableTarget.User)}");

        try
        {
            string senderEmail = Environment.GetEnvironmentVariable("EMAIL_USER", EnvironmentVariableTarget.User);
            string password = Environment.GetEnvironmentVariable("EMAIL_PASS", EnvironmentVariableTarget.User);

            string receiverEmail = "swamy.kalluri@i-raysolutions.com";

            MailMessage mail = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body
            };

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, password),
                EnableSsl = true,
            };

            smtpClient.Send(mail);
            Console.WriteLine("Email sent successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        }
    }
}
