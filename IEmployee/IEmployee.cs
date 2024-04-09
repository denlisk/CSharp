namespace InterfaceEmployee
{
	public interface IEmployee
	{
		public string Name {
			get {
				return Name;
			} set {
				Name = value;
			}
		}
		public uint Age {
			get {
				return Age;
			} set {
				Age = value;
			}
		}
		public GradeLevel Grade {
			get {
				return Grade;
			} set {
				Grade = value;
			}
		}
		public enum GradeLevel
		{
			Nobody,
			Director
		}
		public void Edit(IEmployee employee) {}
	}
}