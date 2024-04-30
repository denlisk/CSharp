namespace CSharp.LinkedList
{
    public class ItemList<T>
    {
        public T Data;
        public ItemList<T>? Next = null;
        public ItemList<T>? Previous = null;
        public ItemList(T data)
        {
            Data = data;
        }
    }
}