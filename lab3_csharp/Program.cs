namespace lab3_csharp;

// Вариант 2
// Односвязный список
internal class Program
{
    private static void Main()
    {
        var ll = new LinkedList();
        
        ll.InsertAtStart(4);
        ll.InsertAtStart(3);
        ll.InsertAtStart(2);
        ll.InsertAtStart(1);
        
        Console.WriteLine("Начало:");
        ll.PrintList(); // 1 2 3 4
        Console.WriteLine($"Длина: {ll.Count}"); // 4
        
        ll.InsertAt(3, 5);
        Console.WriteLine("После вставки на 3 позицию:");
        ll.PrintList(); // 1 2 5 3 4
        Console.WriteLine($"Длина: {ll.Count}"); // 5

        ll.RemoveAt(3);
        Console.WriteLine("После удаления с 3 позиции:");
        ll.PrintList(); // 1 2 3 4
        Console.WriteLine($"Длина: {ll.Count}"); // 4
        
        ll.RemoveAt(4);
        Console.WriteLine("После удаления с 4 позиции:");
        ll.PrintList(); // 1 2 3
        Console.WriteLine($"Длина: {ll.Count}"); // 3
        
        ll.InsertAt(1, 10);
        Console.WriteLine("После вставки на 1 позицию:");
        ll.PrintList(); // 10 1 2 3
        Console.WriteLine($"Длина: {ll.Count}"); // 4
        
        Console.WriteLine($"Нода по индексу 1 равна: {ll[1]}");
        Console.WriteLine($"Нода по индексу 2 равна: {ll[2]}");
        Console.WriteLine($"Нода по индексу 3 равна: {ll[3]}");
    }
}
