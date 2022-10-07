Console.WriteLine("введите три числа для выявления максимального:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;
Console.Write("Максимальное число: ");
Console.Write(max);
