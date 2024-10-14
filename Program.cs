System.Console.WriteLine(Math.PI);
System.Console.WriteLine(Math.Abs(-20));
System.Console.WriteLine(Math.Ceiling(4.7f));
System.Console.WriteLine(Math.Floor(4.7f));
System.Console.WriteLine(Math.Round(4.56f));
System.Console.WriteLine(Math.Min(6,8));
System.Console.WriteLine(Math.Max(6,8));
System.Console.WriteLine(Math.Pow(5,10));

Console.WriteLine("Input circle radius");
double radius = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine("The square with {0} is equal {1}", radius, area);

