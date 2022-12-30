// Знакомство с яз.программирования. Семинар-4.

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-1. Написать программу,кот.принимает на вход число N и счмитает сумму чисел от 1 до N

/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
    {
        sum = sum + current;
    }

    return sum;
}

Console.Write("Сумма от 1 до А.Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.Write($"сумма чисел от 1 до {a} равна {result}");    // решено
*/



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-2. Написать программу,кот.принимает на вход число N и выдает количество цифр в числе N
/*

int AmountN(int n)
{
    int amN = 0;

    while(n > 0)
    {
        n = n/10;
        amN++;
    }
    return amN;
}

Console.Write("Количество цифр в числе. Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

int result = AmountN(a);
Console.Write($"количество цифр в числе равно {result}");  // решено
*/



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-3. Написать программу,кот.принимает на вход число N и выдает произведение цифр от 1 до N
/*
int GetFact(int fact)
{
    int sum = 1;

    for(int current = 1; current <= fact; current++)
    {
        sum = sum * current;
    }

    return sum;
}

Console.Write("Произведение от 1 до А.Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetFact(a);
Console.Write($"произведение чисел от 1 до {a} равна {result}");  // решено
*/


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ТЕМА: СТАТИЧЕСКИЕ МАССИВЫ.

//1.Метод, генерирующий одномерный массив,заполняя его случайными величинами.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}


//2.Метод, выводящий одномерный массив на консоль
void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        //Console.WriteLine($"{i + 1} element is {array[i]}");
    }
    Console.WriteLine();                                            // строка позволяет перенести следующую информацию на другую строку
}



Console.Write("введите количество элементов :");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение :");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// HomeWork
// HomeWork
// HomeWork

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
int NStep(int a, int b)
{
    int i = 1;
    int sum = 1;

    while(i <= b)
    {
        sum = sum * a;
        i++;
    }
    return sum;
}

Console.Write("введите число А :");
int aa = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число В :");
int bb = Convert.ToInt32(Console.ReadLine());

int result = NStep(aa, bb);
Console.Write($"число {aa} в степени {bb} равна {result}");    // решено
*/



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ЗАДАЧА-27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumN(int n)
{
    int sum = 0;

    while(n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;

    }

    return sum;
}

Console.Write("Сумма цифр в числе.Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

int result = SumN(a);
Console.Write($"сумма цифр в числе равно {result}");   // решено
*/



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ЗАДАЧА-29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



/*
//Зад-29 Вар-1

int[] CreateHandArray(int size)      // метод ввода массива пользователем
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массва : ");
        int elemArr = Convert.ToInt32(Console.ReadLine());
        array[i] = elemArr;
    }

    return array;
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");    
    }
    Console.WriteLine();                                            
}



Console.Write("введите количество элементов :");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateHandArray(length);

ShowArray(myArray);                                 // решено
*/


/*
//Зад-29 Вар-2 (модерниз.)

int[] CreateHandArray(int size)      // метод ввода массива пользователем
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)Console.Write("Введите  первый элемент массва : ");
        if(i != 0 & i != size-1)Console.Write("Введите  следующий элемент массва : ");
        if(i == size-1)Console.Write("Введите  последний элемент массва : ");
        int elemArr = Convert.ToInt32(Console.ReadLine());

        array[i] = elemArr;
    }

    return array;
}

void ShowArray(int[] array)          // метод вывода массива на консоль (модерниз.)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)Console.Write("массив: [" + array[i] + ",");
        if(i != 0 & i != array.Length-1)Console.Write(array[i] + ",");
        if(i == array.Length-1)Console.Write(array[i] + "]");
    }
    Console.WriteLine();                                           
}

Console.Write("введите количество элементов :");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateHandArray(length);

ShowArray(myArray);                                        // решено
*/


                













