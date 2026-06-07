

PropertiesDemo pd = new PropertiesDemo();
pd.SetName("Eric");
Console.WriteLine(pd.GetName("something"));
pd.Name = "Cappy";
Console.WriteLine(pd.Name);

public class PropertiesDemo()
{
    private string name;

    public int Age{get;set;}
    public string Name
    {
        get {
            return "This dog: " + name;
        }
        set
        {
            name = value + " is a dog!";
        }
    }

    public string NoROName
    {
        set{
            name = value;
        }
    }

    public void SetName(string value)
    {
        //query my db
        //if name ! exist
        name = value;
    }

    public string GetName(string lastName)
    {
        if (lastName == "something")
        {
            return name + " returned!";
        }
        else
        {
            return "Pffft";
        }
    }

}
