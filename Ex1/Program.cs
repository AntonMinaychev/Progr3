Console.WriteLine("Enter a five-digit number to check for a palindrome");
int a = int.Parse(Console.ReadLine());
int first, second, fourth, fifth; // для палиндрома пятизначного числа 3-я цифра не имеет значения


first = int.Parse(a.ToString()[0].ToString()); 
second = int.Parse(a.ToString()[1].ToString()); 
fourth = int.Parse(a.ToString()[3].ToString()); 
fifth = int.Parse(a.ToString()[4].ToString()); 

if (first == fifth & second == fourth)
Console.WriteLine("This is a palindrome");
else
Console.WriteLine("This is not a palindrome");