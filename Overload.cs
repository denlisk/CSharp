class Overload {
  static string GetTypeInfo(string str) {
  	return "Строка";
  }
  static string GetTypeInfo(int a) {
  	return "Целое число";
  }
  static string GetTypeInfo(double a) {
  	return "Вещественное число";
  }
  static string GetTypeInfo(char c) {
  	return "Символ";
  }
  static void Main() {
    Console.Write("Перегрузка метода с разными типами параметров");
    string str = Console.ReadLine();
    int a = int.Parse(str);
    double b = (double) a;
    char c = str[0];
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(GetTypeInfo(str));
    Console.WriteLine(GetTypeInfo(a));
    Console.WriteLine(GetTypeInfo(b));
    Console.WriteLine(GetTypeInfo(c));
  }
}