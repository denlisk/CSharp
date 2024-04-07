namespace Matrix
{
	public class Matrix
	{
		public uint Rows; // Кол-во строк
		public uint Columns; // Кол-во столбцов
		private readonly int[,] mass; // Двумерный массив для хранения элементов данной матрицы

		/// <summary>
		/// Конструктор класса Matrix.
		/// Создаёт матрицу из одного элемента и устанавливает ему значение ноль.
		/// </summary>
		public Matrix() {
			this.Rows = 1;
			this.Columns = 1;
			this.mass = new int[1,1];
			mass[0,
				0] = 0;
		}
		/// <summary>
		/// Конструктор класса Matrix.
		/// </summary>
		/// <param name="rows">Количество строк</param>
		/// <param name="columns">Количество столбцов</param>
		public Matrix(uint rows, uint columns) {
			this.Rows = rows;
			this.Columns = columns;
			mass = new int[rows,
				columns];
		}
		/// <summary>
		/// Установка значения для элемента матрицы
		/// </summary>
		/// <param name="row">Строка элемента</param>
		/// <param name="column">Столбец элемента</param>
		/// <param name="value">Значение элемента</param>
		public void SetValue(uint row, uint column, int value) {
			mass[row,
				column] = value;
		}
		/// <summary>
		/// Получение значения элемента матрицы
		/// </summary>
		/// <param name="row">Строка элемента</param>
		/// <param name="column">Столбец элемента</param>
		/// <returns>Возвращает значение элемента матрицы</returns>
		public int GetValue(uint row, uint column) {
			Check(row);
			Check(column);
			return mass[row,
				column];
		}
		/// <summary>
		/// Суммирование двух матриц
		/// </summary>
		/// <param name="a">Матрица, к элементам которой необходимо прибавить значения элементов второй матрицы</param>
		/// <param name="b">Матрица, значения элементов которой нужно прибавить к первой матрице</param>
		/// <returns>Возвращает матрицу с сумированными значениями элементов двух матриц</returns>
		public static Matrix operator +(Matrix a, Matrix b) {
			Matrix sum = new Matrix(a.Rows, a.Columns);
			for (uint i = 0; i < a.Rows; i++) {
				for (uint j = 0; j < a.Columns; j++) {
					sum.SetValue(i, j, a.GetValue(i, j) + b.GetValue(i, j));
				}
			}
			return sum;
		}
		/// <summary>
/// Вычитание матриц
		/// </summary>
		/// <param name="a">Матрица, от элементов которой нужно отнять значения элементов второй матрицы</param>
		/// <param name="b">Матрица, значения элементов которой нужно отнять от первой матрицы</param>
		/// <returns>Возвращает матрицу</returns>
		public static Matrix operator -(Matrix a, Matrix b) {
			Matrix dif = new Matrix(a.Rows, a.Columns);
			for (uint i = 0; i < a.Rows; i++) {
				for (uint j = 0; j < a.Columns; j++) {
					dif.SetValue(i, j, a.GetValue(i, j) - b.GetValue(i, j));
				}
			}
			return dif;
		}
		// Если есть переопределение для суммирования элементов, то умножение переопределять не обязательно
		public static Matrix operator *(Matrix a, int num) {
			Matrix mult = new Matrix(a.Rows, a.Columns);
			for (uint i = 0; i < a.Rows; i++) {
				for (uint j = 0; j < a.Columns; j++) {
					mult.SetValue(i, j, a.GetValue(i, j) * num);
				}
			}
			return mult;
		}
	}
		/// <summary>
		/// Переопределение метода ToString
		/// </summary>
		/// <returns>Возвращает строку с таблицей из элементов матрицы</returns>
		public override string ToString() {
			string str = "";
			for (uint i = 0; i < this.Rows; i++) {
				for (uint j = 0; j < this.Columns; j++) {
					str += $"{mass[i, j]} ";
				}
				str += "\n";
			}
			return str;
		}
	}
}
