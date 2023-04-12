Console.WriteLine("Введите число для определения и нажмите ENTER");
int a = int.Parse(Console.ReadLine());

int b = a % 2;

if(b == 0)
{
    Console.WriteLine("Введенное значение является четным");
}
else
{
    Console.WriteLine("Введенное значение НЕ является четным");
}