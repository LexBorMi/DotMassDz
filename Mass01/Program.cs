// напишите программу,которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное  число");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);

Console.WriteLine("вторая цифра этого числа ->" + num1[1]);