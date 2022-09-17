Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if(a>b & a>c)
{
    Console.WriteLine($"Большее: {a}");
}
if(b>a & b>c)
{
    Console.WriteLine($"Большее: {b}");
}
if(c>a & c>b)
{
    Console.WriteLine($"Большее: {c}");
}