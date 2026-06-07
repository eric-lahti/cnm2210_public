static void Main(string[] args)
{
    string? doAnother;
    do
    {
        try
        {
            Console.Write("Please enter num1: ");
            string? num1str = Console.ReadLine();
            int num1 = !string.IsNullOrEmpty(num1str) ? int.Parse(num1str) : -1;

            Console.Write("Please enter num2: ");
            string? num2str = Console.ReadLine();
            int num2 = !string.IsNullOrEmpty(num2str) ? int.Parse(num2str) : -1;

            Console.WriteLine("Num1/Num2:{0}", num1/num2);
        }
        catch(FormatException fex)
        {
            Console.WriteLine("Don't divide by cat" + fex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error! " + ex.Message + "\nException Type: " + ex.GetType());
        }

        finally
        {
            Console.WriteLine("This line always executes");
        }
        Console.WriteLine("Do another (y/n)?");
        doAnother = Console.ReadLine();
    } while (doAnother == "y");

}



void doStuff()
{
    try
    {
        Console.Write("Hi");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void doOtherStuff()
{
    try
    {
        doStuff();
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

doOtherStuff();
string[] arr = {"Hi!"};
Main(arr);

officer captain = new officer();
captain.firstName = "james";
captain.middleName = "tiberius";
captain.lastName = "Kirk";

class officer
{
    public string firstName;
    public string lastName;
    public string middleName;
}