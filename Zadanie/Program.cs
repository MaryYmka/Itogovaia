// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] [“1234”, “1567”, “-2”, “computer science”] → [“-2”] [“Russia”, “Denmark”, “Kazan”] → []

string str = GetString();
int mass = CountStr(str);

string GetString()
{
    Console.WriteLine("Введите строку: "); //Метод для принятия строки с консоли
    string str = Console.ReadLine();
    return str;
}

void PrintArray(int[] num) //Вывод массива
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine(num[i]+ " ");
    }
}

int CountStr(string str) //производим подсчет количества элементов в массиве, длина которых меньше либо равна 3 символа;
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
               if (str.Length <=3)
        {
            count++;
        }
    }
    return count;
    }
string[] NewArray = new string[str.Length]; //создаем новый массив размером, равным количеству подсчитанных элементов;
{
        int index = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str.Length <= 3)
            {
               NewArray[i] = str;
               index++;
            }   
      }
       return NewArray;
}
