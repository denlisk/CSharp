namespace CSharp.LinkedList
{
    class Program
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddToEnd(5);
            list.AddToEnd(3);
            list.AddToEnd(2);
            list.Print();
        }
    }
}
