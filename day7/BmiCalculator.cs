namespace iTi.day7
{
    public class BmiCalculator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private Stack<double> History = new Stack<double>();

        public double Cal(T height, T weight, bool eq)
        {

            double HightM = Convert.ToDouble(height);
            double weightkilo = Convert.ToDouble(weight);

            if (!eq)
            {

                HightM = HightM * 0.3048;
                weightkilo = weightkilo * 0.453592;

            }

            double BMI = 18.5;
            BMI = weightkilo / (HightM * HightM);
            History.Push(BMI);
            return BMI;

        }
        public void BMICAt(double BMI)
        {

            if (BMI < 18.5) Console.WriteLine("Your BMI is Underweight\n");
            if (BMI < 24.9 && BMI >= 18.5) Console.WriteLine("Your BMI is Normal Weight\n");
            if (BMI < 29.9 && BMI >= 24.9) Console.WriteLine("Your BMI is Overweight\n");
            if (BMI > 29.9) Console.WriteLine("Your BMI is Obesity\n");

        }
        public void DisplayHistory()
        {
            Console.WriteLine("Previous BMI Calculations:");
            foreach (var BMI in History)
            {
                Console.WriteLine(BMI);
            }
        }



        public static void Main(string[] args)
      {


            BmiCalculator<double> cal = new BmiCalculator<double>();
            int x;

            Console.WriteLine("Welcome to BMI Calculator ^_^\n");
            do
            {
                Console.WriteLine("Please Enter your choice");
                Console.WriteLine("1-Calculate A new BMI");
                Console.WriteLine("2-Show the History of BMI");
                Console.WriteLine("0- close the program");
                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:

                        Console.Write("Enter Weight by kilograms or pounds : ");
                        double weight = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter height by meters or feet : ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Is the input in metric units? (y/n): ");
                        bool eq = Console.ReadLine() == "y";
                        double BMI = cal.Cal(height, weight, eq);

                        Console.WriteLine($"your BMI = {BMI}\n");
                        cal.BMICAt(BMI);
                        Console.WriteLine("------------------------------------------------------\n");
                        break;

                    case 2:
                        cal.DisplayHistory();
                        break;

                }
            } while (x != 0);



      }
    }

}