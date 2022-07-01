// Напишите программу,которая выводит третью цифру заданного числа или сообщает,Что третьей цифры нет
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);

if (num1.Length > 2)
{
    Console.WriteLine("Третья цифра ->" + num1[2]);

}

else {
    Console.WriteLine("Третьей цифры нет");

}