//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


Console.Write("Введите первое число");
string str1 = Console.ReadLine();
int n1 = int.Parse(str1);
Console.Write("Введите второе число");
string str2 = Console.ReadLine();
int n2 = int.Parse(str2);
Console.Write("Введите третье число");
string str3 = Console.ReadLine();
int n3 = int.Parse(str3);
Console.Write("Введите четвёртое число");
string str4 = Console.ReadLine();
int n4 = int.Parse(str4);
Console.Write("Введите пятое число");
string str5 = Console.ReadLine();
int n5 = int.Parse(str5);
int[] array = {n1,n2,n3,n4,n5};
int length = array.Length;
int result = 0;
for (int i = 0; i < length; i++)
{
    if (array[i] > 0)
    {
        result++;
    }
}
Console.WriteLine("Количество положительных чисел:" + result);