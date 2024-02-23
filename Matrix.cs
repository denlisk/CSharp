namespace Matrix
{
	public class Matrix
	{
		public uint Rows;
		public uint Columns;
		private readonly int[,
		] mass;

		/// <summary>
		///Конструктор класса Matrix.
		///Создаёт матрицу 1 на 1 и заполняет её нулями.
		/// </summary>
		public Matrix() {
			this.Rows = 1;
			this.Columns = 1;
			this.mass = new int[Rows,
				Columns];
			mass[0,
				0] = 0;
		}
		/// <summary>
		/// Конструктор класса Matrix.
		/// </summary>
		/// <param name="rows">Количество строк</param>
		/// <param name="columns">Количество столбцов</param>
		public Matrix(uint rows, uint columns) {
			Check(rows);
			Check(columns);
			this.Rows = rows;
			this.Columns = columns;
			mass = new int[rows,
				columns];
		}
		/// <summary>
		/// Метод установления значения для элемента матрицы
		/// </summary>
		/// <param name="row">Строка элемента</param>
		/// <param name="column">Столбец элемента</param>
		/// <param name="value">Значение элемента</param>
		public void SetValue(uint row, uint column, int value) {
			Check(row);
			Check(column);
			mass[row,
				column] = value;
		}
		public void SetValue(uint row, uint column) {
			Check(row);
			Check(column);
			mass[row,
				column] = 0;
		}
		/// <summary>
		/// Метод получения значения элемента матрицы
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
		/// <param name="a">Матрица, к элементам которой нужно прибавить значения элементов второй</param>
		/// <param name="b">Матрица, значения элементов которой нужно прибавить к первой</param>
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
		/// Разница двух матриц
		/// </summary>
		/// <param name="a">Матрица, от элементов которой нужно отнять значения элементов второй</param>
		/// <param name="b">Матрица, значения элементов которой нужно отнять от первой</param>
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
		// Если есть переопределение для суммы, то умножение можно не переопределять (?)
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
		/// <returns>Возвращает строку с таблицей элементов матрицы</returns>
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
		public static void Check(var value) {
			if (value < 1) {
				// Exception
			}
		}
	}
}