using static InterfaceEmployee.IEmployee;

namespace InterfaceEmployee
{
    public class Manager : IEmployee
    {
        public string Name;
        public uint Age;
        public GradeLevel Grade;
        public Manager(string name, uint age, GradeLevel grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void Edit(IEmployee manager)
        {
            Name = manager.Name;
            Age = manager.Age;
            Grade = manager.Grade;
        }
        public override string ToString()
        {
            return $"Менеджер\t{Name}\t{Age}\t{Grade}";
        }
    }
}
