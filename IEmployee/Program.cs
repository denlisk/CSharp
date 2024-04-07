namespace InterfaceEmployee
{
    class Program
    {
        static void Main()
        {
            EmployeeList<IEmployee> guys = new EmployeeList<IEmployee>();
            Manager vasyan = new Manager("Вася", 20, IEmployee.GradeLevel.Nobody);
            Engineer kolyan = new Engineer("Коля", 54, IEmployee.GradeLevel.Director);
            guys.Add(vasyan);
            guys.Add(kolyan);
            guys.Print();
            guys.Remove(vasyan);
            guys.Print();
        }
    }
}