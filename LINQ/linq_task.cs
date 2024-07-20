using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace iTi.LINQ
{
    internal class linq_task
    {

        public static void Main(string[] args)
        {
            // 1) Given a list of integers, return the product of all numbers
            Console.WriteLine("1)Product of numbers");
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            int product = numbers.Aggregate((x, y) => x * y);
            Console.WriteLine($"The product of numbers = {product}");
            Console.WriteLine("------------------------------------------");

            // 2)Given a list of strings, return a single string that concatenates all the strings,separated by commas.
            Console.WriteLine("2)concatenate Strings:");
            List<string> words = new List<string> { "apple", "banana", "cherry" };
            var result1 = words.Aggregate((x, y) => x + ',' + y);
            Console.WriteLine($"'{result1}'");
            Console.WriteLine("------------------------------------------");

            // 3) Given a list of integers, return a list where each element is the square of corresponding element in the input list.
            Console.WriteLine("3)Square :");
            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            List<int> square = numbers.Select(x => x * x).ToList();
            Console.WriteLine(string.Join(",", square));
            Console.WriteLine("------------------------------------------");

            // 4) Given a list of strings, return a dictionary where the keys are the strings and the values are the lengths of those strings.
            Console.WriteLine("4) Strings and The value of Length with Dictionary :");
            //List<string> words = new List<string> { "apple", "banana","cherry" };
            var result2 = words.ToDictionary(x => x, x => x.Length);
            Console.WriteLine("{" + string.Join(", ", result2.Select(x => $"'{x.Key}': {x.Value}")) + "}");
            Console.WriteLine("------------------------------------------");

            // 5) Given a list of integers, return a list where each element is the square of the corresponding element in the input list.


            Console.Write("5) The intersect between numbers : ");
            List<int> list1 = new List<int> { 1, 2, 3, 4 };
            List<int> list2 = new List<int> { 3, 4, 5, 6 };
            var intersect = list1.Intersect<int>(list2);
            Console.WriteLine(string.Join(",", intersect));
            Console.WriteLine("------------------------------------------");

            // 6) You have a list of employees. Return the name of the employee with the highest salary.
            Console.WriteLine("6) The name of employee with hightest Salary");
            List<Employee> employees = new List<Employee>
            { new Employee("Ali",60000), new Employee("Ramy", 45000), new Employee("Samy", 80000) };

            var emphight = employees.Select(y => y.FirstName).Max();
            Console.WriteLine(emphight);
            Console.WriteLine("------------------------------------------");


            // 7)You have a list of books. Return a list of books grouped by their authors.


            Console.WriteLine("7) Group books with their authors");

            List<Book> books = new List<Book>
            { new Book("Book1", "Author1"),new Book("Book2", "Author2"), new Book("Book3", "Author1") };
            var grbooks = books.GroupBy(x => x.Author).ToList();

            foreach (var group in grbooks)
            {
                Console.WriteLine($"Author: {group.Key}");
                foreach (var book in group)
                {
                    Console.WriteLine($" ~ {book.Title}");
                }
            }
            Console.WriteLine("------------------------------------------");


         // 8) You have a list of sales data. Return the total sales amount for  salesperson.

            Console.WriteLine("8) Total Sales for Salesman");
            List<Sale> sales = new List<Sale> { new Sale("Ali", 100), new Sale("Ramy", 200), new Sale("Ali", 150) };

            var totalsales = sales.GroupBy(x => x.Name,
                (name, SaleGroup) => new { Name = name, TotalSales = SaleGroup.Sum(x => x.Amount) }).ToList();
             foreach (var totalsal in totalsales)
            {
                Console.WriteLine($"{totalsal.Name} - {totalsal.TotalSales}");
            }
            Console.WriteLine("------------------------------------------");


            // 9) You have a list of students with their scores in different subjects
            // Return highest score for each student.
            Console.WriteLine(" highest score for each student :\n");
            List<StudentScores> scores = new List<StudentScores> 
              { new StudentScores("Ali", "Math", 90),
                new StudentScores("Ali", "Science", 85), 
                new StudentScores("Ramy", "Math", 80) };
            var highestScores = scores.GroupBy(s => s.Sname).Select(g => new { Student = g.Key, HighestScore = g.Max(s => s.Score) });

            Console.WriteLine($"9)The Highest score for each student: {{{string.Join(", ", highestScores.Select(s => $"{s.Student}: {s.HighestScore}"))}}}");

            Console.WriteLine("------------------------------------------");

            // 10)  You have a list of orders with prices. Return the average order price.

            Console.Write ("10)Average of order : ");
            List<Order> orders = new List<Order> { new Order(101, 50), new Order(102, 200), new Order(103, 150) };

            var avg = orders.Average(o => o.Price);
            Console.WriteLine(avg);

            Console.WriteLine("------------------------------------------");

            // 11)  Given a list of integers, return a list of tuples where each tuple contains an integer and its frequency in the list
            Console.Write("11)Frequency of numbers :");
            List<int> numbers1 = new List<int> { 1, 2, 2, 3, 3, 3 };
            var frequency = numbers1.GroupBy(x => x).Select(g => new { Number = g.Key, Frequency = g.Count() });
            Console.WriteLine($" [{string.Join(", ", frequency.Select(f => $"({f.Number}, {f.Frequency})"))}]");

            Console.WriteLine("------------------------------------------");

            // 12)  Given a list of strings, return the first string that contains the letter 'e'.
            Console.Write("12) String start with 'e' is ");

            List<string> wordss = new List<string> { "cat", "elephant", "dog","tiger" };
            var firste = wordss.FirstOrDefault(x => x.Contains("e"));
            Console.WriteLine(firste);

            Console.WriteLine("------------------------------------------");

            // 13)  Given a list of integers, return a list of integers where each integer is multiplied by its index
            
            Console.WriteLine("13)each integer is multiplied by its index ");

            //   List<int> numbers = new List<int> { 1, 2, 3, 4 };

            var multi = numbers.Select((number, index) => number * index).ToList();

            Console.WriteLine(string.Join(", ", multi));
            Console.WriteLine("------------------------------------------");

            // 14) Given a list of strings, return a list of the unique characters in all the strings.

            Console.WriteLine("14)the unique characters in all the strings :");


            List<string> words1 = new List<string> { "apple", "banana" };

             var unique = words1.SelectMany(word => word.ToCharArray()).Distinct().ToList();

            Console.WriteLine(string.Join(", ", unique));

            Console.WriteLine("------------------------------------------");


            // 15) Given a list of integers, return the count of even and odd numbers

            Console.WriteLine("15)Even and Odd numbers ");

            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6 };

            var evenCount = numbers2.Count(n => n % 2 == 0);
            var oddCount = numbers2.Count(n => n % 2 != 0);

            Console.WriteLine($"Even: {evenCount}, Odd: {oddCount}");

            Console.WriteLine("------------------------------------------");


            // 16) You have a list of employees with their departments. Return the department with the most employees
            Console.WriteLine("16)the department with the most employees");
            List<Employee> employees1 = new List<Employee> 
            { new Employee("Ali", "HR"),
              new Employee("Ramy", "IT"),
              new Employee("Samy", "HR"),
              new Employee("Sara", "IT"),
              new Employee("John", "IT") };

            var deptemp = employees1.GroupBy(e => e.Department).OrderByDescending(g => g.Count()).First().Key;
            Console.WriteLine(deptemp);

            Console.WriteLine("------------------------------------------");

            // 17) You have a list of products with their categories and prices. Return the most expensive product in each category
            Console.WriteLine("17)the most expensive product in each category");

            List<Product> products = new List<Product>
            { new Product("Laptop","Electronics", 1000),
              new Product("Phone", "Electronics", 800),
              new Product("Shirt", "Clothing", 50),
              new Product("Pants", "Clothing", 60)};

            var exp= products.GroupBy(p => p.categore)
                .Select(g => g.OrderByDescending(p => p.Price).First()).ToList();

            foreach (var producst in exp)
            {
                Console.WriteLine($"{producst.categore}: {producst.Name} - ${producst.Price}");
            }

            Console.WriteLine("------------------------------------------");

            // 18) You have a list of students with their grades in different subjects. Return the average grade for each student.
            Console.WriteLine("18)average grade for each student ");

            List<StudentScores> grades = new List<StudentScores> {
                new StudentScores("Ali", "Math", 90), 
                new StudentScores("Ali", "Science",85), 
                new StudentScores("Ramy", "Math", 80),
                new StudentScores("Ramy","Science", 70) };

            var avggrade = grades.GroupBy(g => g.Sname)
                .Select(g => new { Student = g.Key, AverageGrade = g.Average(s => s.Score) }).ToList();

            foreach (var item in avggrade)
            {
                Console.WriteLine($"Student: {item.Student}, Average Grade: {item.AverageGrade}");
            }


            Console.WriteLine("------------------------------------------");

            // 19) You have a list of transactions with their amounts and dates. Return the total transaction amount for each month.

            Console.WriteLine("19)the total transaction amount for each month :");

            List<Transaction> transactions = new List<Transaction> 
            { new Transaction(new DateTime(2024, 1, 10), 100),
              new Transaction(new DateTime(2024, 1, 20), 200), 
              new Transaction(new DateTime(2024, 2, 5),150) };

            var trans = transactions.GroupBy(t => new { t.Date.Year, t.Date.Month })
                .Select(g => new { Month = $"{g.Key.Year}-{g.Key.Month}", TotalAmount = g.Sum(t => t.Amount) }).ToList();

            foreach (var item in trans)
            {
                Console.WriteLine($"Month: {item.Month}, Total Amount: {item.TotalAmount}");
            }

            Console.WriteLine("------------------------------------------");




            // 20) You have a list of orders with their order dates and amounts. Return the order amounts for the last 7 days.


            Console.WriteLine("19)the order amounts for the last 7 days:");
            List<Order> orders1 = new List<Order> 
            { new Order(new DateTime(2024,7, 10), 50), 
             new Order(new DateTime(2024, 7, 15), 200), 
             new Order(new DateTime(2024, 7, 16), 150) };


            DateTime lastWeek = DateTime.Now.AddDays(-7);
            var last7 = orders1.Where(o => o.date >= lastWeek).ToList();

            foreach (var order in last7)
            {
                Console.WriteLine($"Order Date: {order.date}, Amount: {order.Amount}");
            }


















        }
    }
}
