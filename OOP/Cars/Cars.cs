using System;
using System.Reflection.Metadata.Ecma335;

namespace Cars
{
	/// <summary>
	/// Класс машины
	/// </summary>
	public class Car
	{
		private readonly uint id;
		public string Model = "Unknown"; // значение по умолчанию, может быть изменено в конструкторе const
		public decimal Price = 0;
		public bool BU = false;
		public List < string > Parameters = new List < string > ();
		public Car(string model, decimal price) {
			this.Model = model;
			this.Price = price;
		}
		public Car(string model, bool bu) {
			this.Model = model;
			this.BU = bu;
		}
		public override string ToString() {
			return $"id: {id}\nModel: {Model}\nPrice: {Price}\nBU: {BU}";
		}
		public void Print() {
			if (Parameters != null) {
				foreach (string item in Parameters) {
					Console.WriteLine(item);
				}
				Console.WriteLine();
			} else {
				Console.WriteLine("Parameters are null");
			}
		}
	}
	public class Program	{
		public static void Main() {
			Car BMW = new Car("BMW", 324.34M) {
				Parameters = {
					"Cool",
					"Black"
				}
			};
			Car MERKEDES = new Car("MERK", true) {
				Parameters = {
					"Bruh",
					"SHTO"
				}
			};
			Console.WriteLine(MERKEDES.ToString());
			BMW.Print();
			MERKEDES.Print();
		}
	}
}
