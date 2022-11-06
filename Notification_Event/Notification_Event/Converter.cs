public delegate void Notification(ProcessEvent e);

internal class Converter
{
    public event Notification? _Notify;

    public void ConvertVideo()
    {
        ProcessEvent e = new ProcessEvent();

        try
        {
            Console.WriteLine("Converting video");
            e.IsSuccessful = true;
            e.CompletionTime = DateTime.Now;
            Send_Notification(e);
        }
        catch (Exception ex)
        {
            e.IsSuccessful = false;
            e.CompletionTime = DateTime.Now;
            Send_Notification(e);

        }
    }
    protected void Send_Notification(ProcessEvent e)
    {
        if (_Notify != null)
            _Notify?.Invoke(e);
    }
}