Console.Write("Введите число для проверки его на четность: ");
int a = Convert.ToInt32(Console.ReadLine());
int ost = a % 2;
if (ost == 0)
    Console.WriteLine("Число четное");
else
    Console.WriteLine("Число не четное");

