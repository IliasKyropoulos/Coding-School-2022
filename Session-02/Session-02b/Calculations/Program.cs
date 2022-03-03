// 1

Console.WriteLine("Hello, Ilias");

//2

int x = 3;
int y = 5;

Console.WriteLine(x + y);

Console.WriteLine((float)x / y);

//3

Console.WriteLine(-1 + 5 * 6);

Console.WriteLine(38 + 5 % 7);

Console.WriteLine(14 + (-3 * 6) / 7);

Console.WriteLine(2 + (13 / 6) * 6 + Math.Sqrt(7));

Console.WriteLine(Math.Pow(6, 4) + Math.Pow(5, 7) / (9 % 4));

//4

int age = 20;
string gender = "female";

Console.WriteLine($"You are {gender} and look younger than {age}");

//5

int n = 45678;

n = n % (24 * 3600);
int hours2 = n / 3600;

n %= 3600;
int minutes2 = n / 60;

n %= 60;
int seconds2 = n;

string time2 = hours2 + ":" + minutes2 + ":" + seconds2;

Console.WriteLine(time2);

//6

int hours;
int minutes;
int seconds;

seconds = 45678;

hours = (int)(Math.Floor((double)(seconds / 3600)));
seconds = seconds % 3600;
minutes = (int)(Math.Floor((double)(seconds / 60)));
seconds = seconds % 60;

string time = hours + ":" + minutes + ":" + seconds;

Console.WriteLine(time);

//7

Console.Write("Temperature in Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = ((celsius * 9) / 5) + 32;
Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit);

double kelvin = (celsius + 273.15);
Console.WriteLine("Temperature in Kelvin is: " + kelvin);