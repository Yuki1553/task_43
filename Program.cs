//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

int InputNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


double k1 = InputNumber("Введите коэффициент k1: ");
double k2 = InputNumber("Введите коэффициент k2: ");

double b1 = InputNumber("Введите коэффициент b1: ");
double b2 = InputNumber("Введите коэффициент b2: ");

double x = (b2-b1)/(k1-k2);
Console.WriteLine (x);
double y = k1*x+b1;
Console.WriteLine ("Точка пересечения 2-х прямых с заданными коэффициентами k и b имеет координаты:  ("+x+", "+y+")");