// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите сколько чисел Вы хотите ввести ");
int number = Convert.ToInt32(Console.ReadLine());

int InputNumber(int num)
{
    int ferstnumber = default;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите число ");
        int secondnumber = Convert.ToInt32(Console.ReadLine());
        if (secondnumber > 0) ferstnumber++;
    }
    return ferstnumber;
}

int inputNumber = InputNumber(number);
Console.WriteLine($"-> {inputNumber}");