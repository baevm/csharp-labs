namespace lab3_csharp;

public class Node
{
    public long? val { get; }
    public Node? next { get; set; }
    
    public Node(long? val = null, Node? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

// Индексация начинается с 1
public class LinkedList
{
    public Node head { get; set; } = new();
    public int Count { get; private set; }
    public long? this[int index] => GetAt(index).val;

    private void AddCount()
    {
        Count += 1;
    }

    private void ExtractCount()
    {
        Count -= 1;
    }
    
    public Node InsertAt(int index, long value)
    {
        // Если индекс меньше 1, мы не можем вставить по данной позиции
        if (index < 1) return null;
        if (index > Count)
        {
            throw new Exception($"Позиция {index} больше чем длина листа: {Count}.");
        }

        var temp = head;
        
        // Если индекс == 1, вставляем новую ноду в начало
        if (index == 1)
        {
            InsertAtStart(value);
        }
        else
        {
            while (index != 0)
            {
                index -= 1;

                // Если индекс == 1, значит мы достигли нужной позиции в листе
                // Создаем новую ноду, меняем ссылки и завершаем цикл
                if (index == 1)
                {
                    var newNode = new Node(value);
                    AddCount();

                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }

                temp = temp.next;

                if (head == null)
                {
                    break;
                }
            }
        }

        return head;
    }

    public Node RemoveAt(int index)
    {
        // Если индекс < 1 или не задана head нода выходим
        if (head == null || index < 1)
        {
            return null;
        }
        
        if (index > Count)
        {
            throw new Exception($"Позиция {index} больше чем длина листа: {Count}.");
        }

        // Если индекс == 1, меняем head ноду вперед
        if (index == 1)
        {
            head = head.next;
            ExtractCount();
            return head;
        }

        var temp = head;
        var currPos = 1;

        while (temp != null && currPos < index - 1)
        {
            temp = temp.next;
            currPos += 1;
        }
        
        if (temp?.next == null)
        {
            return null;
        }

        var next = temp.next.next;
        temp.next = next;
        ExtractCount();
        
        return head;
    }

    public void InsertAtStart(long value)
    {
        var newNode = new Node(value);
        
        newNode.next = head;
        head = newNode;
        
       AddCount();
    }

    public Node GetAt(int index)
    {
        var temp = head;
        while (index - 1 > 0 && temp != null)
        {
            temp = temp.next;
            index -= 1;
        }

        return temp;
    }
    
    public void PrintList()
    {
        var temp = head;

        while (temp != null)
        {
            Console.Write($"{temp.val} ");
            temp = temp.next;
        }
    }
}
