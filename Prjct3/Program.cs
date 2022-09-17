Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine($"Данное число четное");
}
else
{
    Console.WriteLine("Данное число делиться с остатком");
}