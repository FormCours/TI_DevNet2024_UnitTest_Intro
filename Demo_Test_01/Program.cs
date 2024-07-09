// See https://aka.ms/new-console-template for more information
using Demo_Test_01.Utils;

Console.WriteLine("Hello, World!");

const double x = 0.1;
const double y = 0.7;

double z = 0;
z = x + y;
Console.WriteLine(MathUtils.Addition(x,y));
Console.WriteLine(MathUtils.Addition(1_200_000_000, 2_100_000_000));