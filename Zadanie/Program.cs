// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] [“1234”, “1567”, “-2”, “computer science”] → [“-2”] [“Russia”, “Denmark”, “Kazan”] → []




string[] FillArray()
{
    Console.Write($"Введите длину массива:\t");
    string[] stringArray = new string[int.Parse(Console.ReadLine()!)];
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива:\t");
        stringArray[i] = Console.ReadLine()!;
    }
    return stringArray;
}


//Console.Write("Введите количество элементов массива:\t"); // Создание массива с размером заданным пользователем
//int elementsCount = int.Parse(Console.ReadLine());
//char [] Array = new char [elementsCount];
//
//for (int i = 0; i < Array.Length; i++) //Ввод каждого элемента нашего массива
//{
   // Console.Write($"\nВведите элемент массива под индексом {i}:\t");
    //Array[i] = char.Parse(Console.ReadLine());
//}
//Console.WriteLine("\nВывод массива: ");


int CountStr(string[] massarr) //производим подсчет количества элементов в массиве, длина которых меньше либо равна 3 символа;
{
    int count = 0;
    for (int i = 0; i < massarr.Length; i++)
    {
               if (massarr.Length <=3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(string[] mass)//создаем новый массив размером, равным количеству подсчитанных элементов;
{
    int rezultArrayMass = CountStr(mass);
    string[] rezultArray = new string[rezultArrayMass]; 
        int index = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass.Length <= 3)
            {
               rezultArray[i] = mass[i];
               index++;
            }   
      }
   return rezultArray;   
}

void PrintArray(string[] stringArray) //Вывод массива
{
    Console.WriteLine();
    Console.WriteLine("Итоговый массив:");
    Console.Write($"[{string.Join(", ", stringArray)}]");

}
//FillArray(stringArray);
//PrintArray(stringArray);
PrintArray(NewArray(FillArray()));