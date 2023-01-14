// task 27

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int val1 = num;
int val2 = 0;

for (int i = 10; num/i != 0; i *= 10)
{
    val2 = val2 + val1 % 10;
    val1 = val1/10;
}

val2 = val2 + val1;
Console.WriteLine(val2);


