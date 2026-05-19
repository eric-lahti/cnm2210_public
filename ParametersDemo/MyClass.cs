public class MyClass
{
    public string TestOverload(string strParam)
    {
        //Console.WriteLine("String overload called {0}", strParam);
        return "Tested overload " + strParam;
    }

    public  int TestOverload(int intParam)
    {
        //Console.WriteLine("Numbers called {0}", intParam);
        return intParam * 10; 
    }
}