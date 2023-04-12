Console.WriteLine("Введите число N и нажмите ENTER");
int a = int.Parse(Console.ReadLine());

int b = 2;

if(a > 1)
{
    while(b <= a)
    {
    Console.WriteLine(b);
    b = b + 2;
    }
}