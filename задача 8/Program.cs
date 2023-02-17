// задача 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int x = 2;

if(number > 1)
{
    while(x <= number)
    {
        Console.Write(x + " ");
        x = x + 2;
    }
}