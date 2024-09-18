// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

#region
int a = 2;
int b = 3;
int c = a+b;
Console.WriteLine(a);
Console.WriteLine("c=a+b");
Console.WriteLine("{0}={1}+{2}", c, a, b);
Console.WriteLine();


a=10;
Console.WriteLine(a);
Console.WriteLine("{0}={1}+{2}", c,a,b);

#endregion
#region Circle

double radius = 5;
const double PI = 3.14159;
double Area = PI * radius * radius;
Console.WriteLine("\n 計算圓面積");
Console.WriteLine("radius ={0},Area ={1}", radius, Area);


#endregion