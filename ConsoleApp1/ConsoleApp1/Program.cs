using System.Text;

System.Globalization.CultureInfo customCulture =
(System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть перше число");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть друге число");
double y = double.Parse(Console.ReadLine());

Console.WriteLine($"{x}+{y}= {x+y}");