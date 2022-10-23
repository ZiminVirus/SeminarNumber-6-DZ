// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1 ");
int b1number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1 ");
int k1number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2 ");
int b2number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2 ");
int k2number = Convert.ToInt32(Console.ReadLine());


double CoordinateX(int b1num, int k1num, int b2num, int k2num)
{
    double x = Convert.ToDouble(b2num - b1num) / (k1num - k2num);
    return (x);
}


double CoordinateY(int b1numb, int k1numb, int b2numb, int k2numb)
{
    double coordinateX = CoordinateX(b1number, k1number, b2number, k2number);
    double y = Convert.ToDouble(k1numb * (coordinateX) + b1numb);
    return (y);
}


double coordinateX = CoordinateX(b1number, k1number, b2number, k2number);
double coordinateY = CoordinateY(b1number, k1number, b2number, k2number);
Console.WriteLine($"b1 = {b1number}, k1 = {k1number}, b2 = {b2number}, k2 = {k2number} -> ({coordinateX}; {coordinateY})");
