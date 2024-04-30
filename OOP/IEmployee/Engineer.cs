using static InterfaceEmployee.IEmployee;

namespace InterfaceEmployee
{
    public class Engineer : IEmployee
    {
        public string Name;
        public uint Age;
        public GradeLevel Grade;
        public Engineer(string name, uint age, GradeLevel grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void Edit(IEmployee engineer)
        {
            Name = engineer.Name;
            Age = engineer.Age;
            Grade = engineer.Grade;
        }
        public override string ToString()
        {
            return $"Инженер  \t{Name}\t{Age}\t{Grade}";
        }
    }
}
