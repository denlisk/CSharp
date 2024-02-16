using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace ComplexMatrix
{
	public class ComplexNumber
	{
		public int Real;
		public double Imaginary;
		public ComplexNumber() {
			this.Real = 0;
			this.Imaginary = 0.0;
		}
		public ComplexNumber(int real) {
			this.Real = real;
		}
		public ComplexNumber(double imaginary) {
			this.Imaginary = imaginary;
		}
		public ComplexNumber(int real, double imaginary) {
			this.Real = real;
			this.Imaginary = imaginary;
		}
		public ComplexNumber(double imaginary, int real) {
			this.Real = real;
			this.Imaginary = imaginary;
		}
		public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) {
			ComplexNumber sum = new ComplexNumber() {
				this.Real = a.Real + b.Real;
				this.Imaginary = a.Imaginary + b.Imaginary;
			}
			return sum;
		}
		public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) {
			ComplexNumber dif = new ComplexNumber() {
				this.Real = a.Real - b.Real;
				this.Imaginary = a.Imaginary - b.Imaginary;
			};
			return dif;
		}
		public override string ToString() {
			return $"{this.Real} + {this.Imaginary}i";
		}
	}
	public class Matrix
	{
		public int Rows;
		public int Columns;
		private int[,
		] mass;
///<summary>
///Конструктор класса Matrix.
///Создаёт матрицу 1 на 1 и заполняет её нулями.
///</summary>
		public Matrix() {
			this.Rows = 1;
			this.Columns = 1;
			this.mass = new int[Rows,
				Columns];
			for (int i = 0; i < Rows; i++) {
				for (int j = 0; j < Columns; j++) {
					mass[i,
						j] = 0;
				}
			}
		}
		public Matrix(int rows, int columns) {
			this.Rows = rows;
			this.Columns = columns;
			mass = new int[rows,
				columns];
		}
		public void SetValue(int row, int column, int value) {
			mass[row,
				column] = value;
		}
		public int GetValue(int row, int column) {
			return mass[row,
				column];
		}
		public static Matrix operator +(Matrix a, Matrix b) {
			Matrix sum = new Matrix(a.Rows, a.Columns);
			for (int i = 0; i < a.Rows; i++) {
				for (int j = 0; j < a.Columns; j++) {
					sum.SetValue(i, j, a.GetValue(i, j) + b.GetValue(i, j));
				}
			}
			return sum;
		}
		public static Matrix operator -(Matrix a, Matrix b) {
			Matrix sum = new Matrix(a.Rows, a.Columns);
			for (int i = 0; i < a.Rows; i++) {
				for (int j = 0; j < a.Columns; j++) {
					sum.SetValue(i, j, a.GetValue(i, j) - b.GetValue(i, j));
				}
			}
			return sum;
		}
		public override string ToString() {
			string str = "";
			for (int i = 0; i < this.Rows; i++) {
				for (int j = 0; j < this.Columns; j++) {
					str += $"{mass[i, j]} ";
				}
				str += "\n";
			}
			return str;
		}
	}
}