// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());
switch (task){
    case 41: 
        Console.Clear();
        task41();
        break;
    case 43: 
        Console.Clear();
        task43();
        break;
    default: Console.WriteLine("Неправильный ввод");
        break;
}
void task41(){
    Console.Write("Введите количество чисел: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 1; i <= num; i++){
        Console.Write($"введите {i}-е число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count = count + 1;
    }
    Console.WriteLine($"Вы ввели {count} чисел/числа больше нуля");
}
void task43(){
    Console.Write("Введите значение b1 для первого отрезка: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k1 для первого отрезка: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение b2 для второго отрезка: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k2 для второго отрезка: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Raschet(b1, k1, b2, k2);

}
void Raschet(double b1, double k1, double b2, double k2){
    double x;
    double y;
    if(k1 == k2) Console.WriteLine("Переменные не пересекаются");
    else{
    x = (b2-b1)/(k1 - k2);
    y = k1*x + b1;
    Console.WriteLine($"Координаты точки пересечения ({x};{y})");
    }

}
