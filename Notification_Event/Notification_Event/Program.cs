Converter converter = new Converter();
converter._Notify += MailNotificaton;
converter._Notify += PhoneNotificaton;
converter.ConvertVideo();
Console.WriteLine("______________-");
converter._Notify -= PhoneNotificaton;
converter.ConvertVideo();


static void MailNotificaton(ProcessEvent e)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Mail notification");
    Console.WriteLine("Process " + (e.IsSuccessful ? "completed successfully" : "failed"));
    Console.WriteLine("Completion time " + e.CompletionTime.ToString());
    Console.ForegroundColor = ConsoleColor.White;

}

static void PhoneNotificaton(ProcessEvent e)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Phone notification");
    Console.WriteLine("Process " + (e.IsSuccessful ? "completed successfully" : "failed"));
    Console.WriteLine("Completion time " + e.CompletionTime.ToString());
    Console.ForegroundColor = ConsoleColor.White;
}