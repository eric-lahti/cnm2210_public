public class Train
{
    public string TrainNumber{get;set;}
    public void MoveForeward()
    {
        Console.WriteLine("Foreward!");
    }

    public void Stop()
    {
        Console.WriteLine("Stop!");
    }
}