using iTi.day7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iTi.day7
{
    public class Calculator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public Func<T, T, T> Add { get; set; }
        public Func<T, T, T> Subtract { get; set; }
        public Func<T, T, T> Multiply { get; set; }
        public Func<T, T, T> Divide { get; set; }

        public Calculator(Func<T, T, T> add, Func<T, T, T> subtract, Func<T, T, T> multiply, Func<T, T, T> divide)
        {

            this.Add = add;
            this.Subtract = subtract;
            this.Multiply = multiply;
            this.Divide = divide;
        }


        public T PerformAddition(T a, T b) => Add(a, b);
        public T PerformSubtraction(T a, T b) => Subtract(a, b); 
        public T PerformMultiplication(T a, T b) => Multiply(a, b);
        public T PerformDivision(T a, T b) => Divide(a, b);


    }
}
