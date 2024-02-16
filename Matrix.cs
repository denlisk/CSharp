namespace Matrix
{
    public class Matrix
    {
        public int Rows;
        public int Columns;
        private readonly int[,] mass;

        /// <summary>
        ///Конструктор класса Matrix.
        ///Создаёт матрицу 1 на 1 и заполняет её нулями.
        /// </summary>
        public Matrix()
        {
            this.Rows = 1;
            this.Columns = 1;
            this.mass = new int[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    mass[i,j] = 0;
                }
            }
        }
        /// <summary>
        /// Конструктор класса Matrix.
        /// </summary>
        /// <param name="rows">Количество строк</param>
        /// <param name="columns">Количество столбцов</param>
        public Matrix(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            mass = new int[rows, columns];
        }
        /// <summary>
        /// Метод установления значения элементу матрицы
        /// </summary>
        /// <param name="row">Строка элемента</param>
        /// <param name="column">Столбец элемента</param>
        /// <param name="value">Значение элемента</param>
        public void SetValue(int row, int column, int value)
        {
            mass[row, column] = value;
        }
        /// <summary>
        /// Метод получения значения элемента матрицы
        /// </summary>
        /// <param name="row">Строка элемента</param>
        /// <param name="column">Столбец элемента</param>
        /// <returns></returns>
        public int GetValue(int row, int column)
        {
            return mass[row, column];
        }
        /// <summary>
        /// Суммирование двух матриц
        /// </summary>
        /// <param name="a">Матрица, к элементам которой нужно прибавить значения элементов второй</param>
        /// <param name="b">Матрица, значения элементов которой нужно прибавить к первой</param>
        /// <returns>Возвращает матрицу с сумированными значениями элементов</returns>
        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix sum = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    sum.SetValue(i, j, a.GetValue(i, j) + b.GetValue(i, j));
                }
            }
            return sum;
        }
        /// <summary>
        /// Разница двух матриц
        /// </summary>
        /// <param name="a">Матрица, у элементов которой нужно отнять значения элементов второй</param>
        /// <param name="b">Матрица, значения элементов которой нужно отнять от первой</param>
        /// <returns>Возвращает матрицу с отнятыми из первой значениями элементов второй</returns>
        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix dif = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    dif.SetValue(i, j, a.GetValue(i, j) - b.GetValue(i, j));
                }
            }
            return dif;
        }
        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        /// <returns>Возвращает строку с таблицей элементов матрицы</returns>
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    str += $"{mass[i, j]} ";
                }
                str += "\n";
            }
            return str;
        }
    }
}