namespace ComplexNumbers
{
    public class ComplexNumber
    {
        public int Real;
        public double Imaginary;
        public ComplexNumber()
        {
            this.Real = 0;
            this.Imaginary = 0.0;
        }
        public ComplexNumber(int real)
        {
            this.Real = real;
        }
        public ComplexNumber(double imaginary)
        {
            this.Imaginary = imaginary;
        }
        public ComplexNumber(int real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        public ComplexNumber(double imaginary, int real)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber sum = new ComplexNumber()
            {
                Real = a.Real + b.Real,
                Imaginary = a.Imaginary + b.Imaginary
            };
            return sum;
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber dif = new ComplexNumber()
            {
                Real = a.Real - b.Real,
                Imaginary = a.Imaginary - b.Imaginary
            };

            return dif;
        }
        public override string ToString()
        {
            return $"{this.Real} + {this.Imaginary}i";
        }
    }
}
