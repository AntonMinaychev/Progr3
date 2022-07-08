Console.WriteLine("Enter x coordinate of the first point");
double x1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter y coordinate of the first point");
double y1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter z coordinate of the first point");
double z1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Enter x coordinate of the second point");
double x2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter y coordinate of the second point");
double y2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter z coordinate of the second point");
double z2 = Double.Parse(Console.ReadLine());

double d;

d = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
Console.WriteLine($"Distance is {d}");