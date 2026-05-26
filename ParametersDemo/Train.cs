public class Train
{
    string MyName, 
        MyLastName, 
        MyFirstName;

    double MyDouble = 0.0;
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