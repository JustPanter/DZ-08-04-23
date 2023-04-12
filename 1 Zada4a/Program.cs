Console.WriteLine("Введите первое значение ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе значение ");
int B = int.Parse(Console.ReadLine());
int max = B;
int min = A;
    if (A > max) max = A;
    if (B > max) max = B;
    if (A < min) min = A;
    if (B < min) min = B;
Console.WriteLine("Наибольшее значение = " + max);

Console.WriteLine("Наименьшее значение = " + min);