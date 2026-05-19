BasicMath.AddValues MyClass = new BasicMath.AddValues();
BasicMath.MultValues MyOtherClass = new BasicMath.MultValues();

int my_a = 1;
int my_b = 2;
string my_c_string = "3";

int my_c = int.Parse(my_c_string);

Console.WriteLine(MyClass.add_vals(my_a, my_b).ToString());
Console.WriteLine(MyClass.add_vals(my_a,my_b,my_c).ToString());

Console.WriteLine(MyOtherClass.mult_vals(my_a,my_b).ToString());
Console.WriteLine(MyOtherClass.mult_vals(my_a,my_b,my_c).ToString());