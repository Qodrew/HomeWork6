/*  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */

Console.Clear();

Console.Write("Введите значение k1: ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
float k2 = float.Parse(Console.ReadLine());
Console.Write("Введите значение b1: ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
float b2 = float.Parse(Console.ReadLine());


PrintAnsver(k1, k2, b1, b2);


void PrintAnsver (float firstNum, float secondNum, float thirdNum, float fourthNum) {  //нахождение точки пересечения прямых
    float xNum = ((fourthNum - thirdNum) / (firstNum - secondNum));
    float yNum = (secondNum*thirdNum-firstNum*fourthNum)/(secondNum-firstNum);
    System.Console.WriteLine($"Точка пересечения прямых: ({xNum}; {yNum})");
}
