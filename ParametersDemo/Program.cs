static void Test(int aValue)
{
    aValue = 111;
    Console.WriteLine("In Test aValue is {0}", aValue);
}

static void TestArray(int[] anArray)
{
    anArray[0] = 111;
    Console.WriteLine("In Test Value is {0}", anArray[0]);
}

static void TestOut(out int aValue)
{
    aValue = 222;
    Console.WriteLine("In TestOut value is {0}", aValue);
}

static void TestRef(ref int aValue)
{
    aValue = 333;
    Console.WriteLine("In TestRef value is {0}", aValue);
}

static void TestOptional(int aValue = 444)
{
    Console.WriteLine("In TestOptional value is {0}", aValue);
}

static void TestMultiple(int aValue, int bValue = 222, int cValue = 333)
{
    Console.WriteLine("Inside TestMultiple" +
        "Values " +
        "{0}, {1}, {2}", aValue,bValue,cValue);
}

//byval
Console.WriteLine("Pass by value test");
int testVal1 = 1;
Console.WriteLine("Original value {0}", testVal1);
Test(testVal1);
Console.WriteLine("Returned value {0}",testVal1);
//byref
Console.WriteLine("Pass in a reference type test");
int[] testArray = {1,1,1};
Console.WriteLine("Original value {0}", testArray[0]);
TestArray(testArray);
Console.WriteLine("Returned value {0}", testArray[0]);
//outval
Console.WriteLine("Out parameter test");
int testVal2 = 222;
Console.WriteLine("Original value {0}", testVal2);
TestOut(out testVal2);
Console.WriteLine("Returned valued {0}", testVal2);
//ref test
Console.WriteLine("Out parameter test");
int testVal3 = 3;
Console.WriteLine("Original value {0}", testVal3);
TestRef(ref testVal3);
Console.WriteLine("Returned valued {0}", testVal3);
// optional test
Console.WriteLine("TestOption with a parameter");
TestOptional(4);
TestOptional();
//multiples
Console.WriteLine("Test multi");
TestMultiple(1,2,3);
TestMultiple(111,666);
TestMultiple(1, cValue:3);
Console.WriteLine("test overload");
MyClass cls = new MyClass();
Console.WriteLine(cls.TestOverload("Overload!"));
Console.WriteLine(cls.TestOverload(1));