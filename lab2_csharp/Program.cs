namespace lab2_csharp;

// Вариант 2 
// Формула 2
internal class Program
{
    private static void Main(string[] args)
    {
        // Угол x в градусах
        Console.Write("x (в градусах): ");
        var x = Convert.ToDouble(Console.ReadLine());
        
        // Перевод из градусов в радианы
        x = x * Math.PI / 180;
        
        // Количество членов в ряде
        Console.Write("n: ");
        var n = Convert.ToInt32(Console.ReadLine());
        
        var result = Calculate(x, n);
        Console.WriteLine($"результат: {result}");
    }
   
    // Ряд тейлора для sin(x)
    static double Calculate(double x, int n)
    {
        var result = 0.0;

        for (var i = 0; i < n; i++)
        {
            var chislitel = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1);
            var znamenatel = Factorial(2 * i + 1);
            
            var curr =  chislitel / znamenatel;
            result += curr;
        }

        return result;
    }

    static double Factorial(double num)
    {
        if (num == 0 || num == 1)
            return 1;
        
        return num * Factorial(num - 1);
    }
}
