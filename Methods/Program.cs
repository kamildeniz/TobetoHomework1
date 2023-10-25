// See https://aka.ms/new-console-template for more information



//değer döndürmeyen metot
using Methods;

static void Add()
{
    Console.WriteLine("Added!");
}
Add();
Add();
Add();
Add();

// Int değer döndüren metot
static int Add2(int number1, int number2)
{
    var result = number1 + number2;
    return result;
}
var result = Add2(20, 30);
Console.WriteLine(result);

// Default parametreli metot
static int Add3(int number1 = 10, int number2 = 30)
{
    var result2 = number1 + number2;
    return result2;
}
var result2 = Add3(20);
Console.WriteLine(result2);

// Ref Keyword
static int Add4(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}
int number1 = 20;
int number2 = 100;
var result3 = Add4(ref number1, number2);
Console.WriteLine(result3);
Console.WriteLine(number1);

// Out Keyword
static int Add5(out int number1, int number2)
{
    number1 = 15;
    return number1 + number2; 
}
var result4 = Add5(out number1, number2);
Console.WriteLine(result4);

// Method Overloading
var overLoading1 = OverLoading.Multiply(2, 4);
var overLoading2 = OverLoading.Multiply(2, 4, 5);
Console.WriteLine(overLoading1);
Console.WriteLine(overLoading2);

// Params Keyword'ü
Console.WriteLine(Add6(1, 2, 3, 4, 5, 6));
static int Add6(params int[] numbers)
{
    return numbers.Sum();
}