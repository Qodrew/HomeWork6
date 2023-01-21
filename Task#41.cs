// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Введите количество чисел для ввода: ");
int countInputNum = int.Parse(Console.ReadLine());

int[] arrayNum = new int[countInputNum];

FillArray(arrayNum);
PrintArray(arrayNum);
positiveNum(arrayNum);

int[] FillArray (int[] arrayInput) {  //заполнение массива с клавиатуры числами
    System.Console.WriteLine("Введите числа: ");
    for (int i = 0; i < countInputNum; i++)
    {
        arrayInput[i] = int.Parse(Console.ReadLine());
    }
    return arrayInput;
}

void PrintArray (int[] arrayInput) {   // вывод массива в консоль
    foreach (int numInArray in arrayInput) {
        Console.Write($"{numInArray} ");
    }
    Console.WriteLine();
}

void positiveNum (int[] arrayInput) {  // счетчик положительных чисел в массиве
    int counterPositiveNum = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
        if (arrayInput[i] > 0) {
            counterPositiveNum++;
        }
    }
    Console.WriteLine($"Количество положительных чисел = {counterPositiveNum}");
}
