using System;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Important Update: System Maintenance Tonight!";

            // Scenario 1: Email only notification
            Console.WriteLine("=== Scenario 1: Email Only ===");
            INotifier emailOnly = new EmailNotifier();
            emailOnly.Send(message);

            Console.WriteLine();

            // Scenario 2: Email + SMS notification
            Console.WriteLine("=== Scenario 2: Email + SMS ===");
            INotifier emailAndSMS = new SMSNotifierDecorator(new EmailNotifier());
            emailAndSMS.Send(message);

            Console.WriteLine();

            // Scenario 3: Email + SMS + Slack notification
            Console.WriteLine("=== Scenario 3: Email + SMS + Slack ===");
            INotifier emailSMSAndSlack = new SlackNotifierDecorator(
                new SMSNotifierDecorator(new EmailNotifier())
            );
            emailSMSAndSlack.Send(message);
        }
    }
}
