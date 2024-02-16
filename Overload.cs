/// <summary>
/// Перегрузка метода с разными типами параметров
/// </summary>
class Overload
{
    static string GetTypeInfo(string str)
    {
        return "Строка";
    }
    static string GetTypeInfo(int integral)
    {
        return "Целое число";
    }
    static string GetTypeInfo(double real)
    {
        return "Вещественное число";
    }
    static string GetTypeInfo(char symbol)
    {
        return "Символ";
    }
    static void Main()
    {
        var input = Console.ReadLine();
        if (input != null)
        {
            string str = input;
            int integral = int.Parse(input);
            double real = (double)integral;
            char symbol = input[0];
            Console.WriteLine(GetTypeInfo(str));
            Console.WriteLine(GetTypeInfo(integral));
            Console.WriteLine(GetTypeInfo(real));
            Console.WriteLine(GetTypeInfo(symbol));
        }
        else
        {
            Console.WriteLine("input is null");
        }
    }
}