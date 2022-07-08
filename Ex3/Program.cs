Console.WriteLine("Inter some number");
Double a = Double.Parse(Console.ReadLine());
Double b = 0;

do
{
b = Math.Pow(a, 3);
Console.WriteLine(b);
a--;
}
while (a > 0);