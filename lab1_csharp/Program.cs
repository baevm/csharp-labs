
using Microsoft.VisualBasic;

namespace lab1_csharp;

// Вариант 2
// Сортировка слиянием по частоте появления слов в тексте.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите текст:");
        var text = Console.ReadLine();

        if (text.Length < 1)
        {
            Console.WriteLine("Вы ничего не ввели.");
            return;
        }

        var arr = text.Split(" ").ToList();
        
        var wordsCount = WordCounter.Get(arr);
        
        MergeSort(wordsCount);

        Console.WriteLine("Отсортированные слова:");
        foreach (var word in wordsCount)
        {
            Console.Write("{0} ", word); 
        }
    }
    
    private static void MergeSort(IList<KeyValuePair<string, int>> arr)
    {
        MergeSort(arr, 0, arr.Count);
    }

    private static void MergeSort(IList<KeyValuePair<string, int>> arr, int left, int right)
    {
        // Если в массиве один элемент то он уже отсортирован
        if (left + 1 >= right)
        {
            return;
        }
        
        // Разбиваем массив на две части до тех пор пока не останется по одному элементу
        // каждый из которых сортируется рекурсивно
        var mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid, right);
        
        // Производим операцию слияния двух частей массива
        Merge(arr, left, mid, right);
    }

    private static void Merge(IList<KeyValuePair<string, int>> arr, int left, int mid, int right)
    {
        var p1 = 0;
        var p2 = 0;
        var temp = new KeyValuePair<string,int>[right - left];
        
        while (left + p1 < mid && mid + p2 < right)
        {
            if (arr[left + p1].Value < arr[mid + p2].Value)
            {
                temp[p1 + p2] = arr[left + p1];
                p1 += 1;
            }
            else
            {
                temp[p1 + p2] = arr[mid + p2];
                p2 += 1;
            }
        }
        
        // Если один из массивов закончился
        // Дописываем другой массив
        while (left + p1 < mid)
        {
            temp[p1 + p2] = arr[left + p1];
            p1 += 1;
        }

        while (mid + p2 < right)
        {
            temp[p1 + p2] = arr[mid + p2];
            p2 += 1;
        }
        
        // Записываем отсортированный массив в исходный
        for (var i = 0; i < p1 + p2; i++)
        {
            arr[left + i] = temp[i];
        }
    }
}
