Console.Write("Please enter some text: ");
String text = Console.ReadLine();            

//Instantiate three delegate objects            
DispStrDelegate saying1 = new DispStrDelegate(Capitalize);
DispStrDelegate saying2 = new DispStrDelegate(LowerCased);
DispStrDelegate saying3 = new DispStrDelegate(Console.WriteLine);

DispStrDelegate sayings = new DispStrDelegate(Capitalize);
sayings += new DispStrDelegate(LowerCased);
sayings += new DispStrDelegate(Console.WriteLine);


//Call them one after the other
saying1(text);
saying2(text);
saying3(text);

Console.WriteLine("Running multi cast directly: ");
sayings(text);

Console.WriteLine("Delegate as argument");
RunMyDelegate(sayings, text);

Console.WriteLine("Running by passing in a lambda expression: ");
RunMyDelegate((string t) => { Console.WriteLine("Lambda: " + t); }, text); 
RunMyDelegate((string t) => {Capitalize("Lambda: " + t); }, text);
RunMyDelegate((string t) => {LowerCased("Lambda: " + t); }, text);

static void Capitalize(string text)
{
    Console.WriteLine("Your input capatilized --> "+text.ToUpper());
}

// Method that lower cases a string.
static void LowerCased(string text)
{
    Console.WriteLine("Your input lower cased --> "+text.ToLower());
}

static void RunMyDelegate(DispStrDelegate del, string textParam)
{
    del(textParam);
}


delegate void DispStrDelegate(string param);

