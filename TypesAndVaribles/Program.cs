// See https://aka.ms/new-console-template for more information
//Value Types
Console.WriteLine("Hello, World!");
// int veri tipi =  -2147483648 ile 2147483647 sınırlıdır.
int number1 = 10;
Console.WriteLine("Number is {0}", number1);

//long veri tipi = -9223372036854775808 ile 9223372036854775807 sınırlıdır
long number2 = -9223372036854775808;
Console.WriteLine("Number2 is {0}", number2);

// short veri tipi = -32768 ile 32767 sınırlıdır
short number3 = 32767;
Console.WriteLine("Number3 is {0}", number3);


// byte veri tipi => 0 ile 255 arasındadır
byte number4 = 255;
Console.WriteLine("Number4 is {0}", number4);
// bool veri tipi = true/false.
bool condition = false;
Console.WriteLine("MyCondition is {0}", condition);

// char tipi tek karakter verileri tutar
char character = 'A';
Console.WriteLine("Character is {0}", character);
Console.WriteLine("Character is {0}", (int)character); // Unboxing

// double veri tipi
double number5 = 10.4;
Console.WriteLine("Number5 is {0}", number5);

// decimal veri tipi
decimal number6 = 10.4m;
Console.WriteLine("Number6 is {0}", number6 + " (decimal)");


// enum sabitleri
Console.WriteLine("enum sabiti => " + Days.Friday);
Console.WriteLine("enum sabitinin değeri => " + (int)Days.Friday);

// var keyword'ü
var number7 = 10;
number7 = 'A';
//number7 = "A"  //yanlış kullanım!
Console.WriteLine("Number7 is {0}", number7);

Console.ReadKey();

enum Days // enum tanımlaması
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}