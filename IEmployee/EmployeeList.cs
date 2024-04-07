namespace InterfaceEmployee
{
    public class EmployeeList<IEmployee>
    {
        List<IEmployee> list = new List<IEmployee>();
        public void Add(IEmployee employee)
        {
            list.Add(employee);
        }
        public void Remove(IEmployee employee)
        {
            list.Remove(employee);
        }
        public void Print()
        {
            if (list.Count > 0)
            {
                Console.WriteLine($"\nПрофессия\tИмя\tВозраст\tДолжность".ToUpper());
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Сотрудники отсутствуют");
            }
        }
    }
}
