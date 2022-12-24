void MyFunc(int num)
{
    Console.WriteLine($"the number is {num}");
}

int Product(int num1, int num2)
{
    return num1 * num2;
}

int Increase(int num1, int num2 = 1)
{
    return num1 + num2;
}

void Increment(ref int num)
{
    num++;
}

(int, int, int) MathExpressions(int num1, int num2)
{
    return (num1 + num2, num1 * num2, num1 - num2);
}

int[] Func()
{
    int[] arr = { 1, 2, 3 };
    return arr;
}

// Main
MyFunc(122);
Console.WriteLine($"The product of 10 and 12 is {Product(10, 12)}");
Console.WriteLine($"Increment of 10 , 12 is {Increase(10, 12)}");
Console.WriteLine($"Increment of 10 is {Increase(10)}");

int num = 2;
Increment(ref num);
Console.WriteLine($"num is {num}");

(int, int, int) res = MathExpressions(2, 3);
Console.WriteLine($"the sum is {res.Item1}");
Console.WriteLine($"the product is {res.Item2}");
Console.WriteLine($"the substract is {res.Item3}");

Console.WriteLine($"{Func()[0]}");

// var tuple = new Tuple<int, string, bool, int>(1, "ehsan", false, 4);
// var tuple = (1, "ehsan", false, 3);

// foreach (var item in tuple)
// {
//     Console.WriteLine(item);
// }

(string, int, bool) tuple = ("hello", 42, true);

// Iterate over the elements of the tuple
foreach (var element in tuple)
{
    Console.WriteLine(element);
}