using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTi.LINQ
{
    public class Transaction { 
        public DateTime Date {  get; set; }
        public int Amount { get; set; }
        public Transaction(DateTime date,int amount)
        {
            this.Date = date;
            this.Amount = amount;
        }
    }  
    public class StudentScores
    {
        public int Score { get; set; }
        public string Sname { get; set; }
        public string Subject { get; set; }
        public StudentScores(string Sname, string subject, int score)
        {
            this.Score = score;
            this.Subject = subject;
            this.Sname = Sname;
        }
    }

        public class Book
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public Book(string title , string author) {

             Title = title ;
            Author = author;
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Salary { get; set; }
        public string Department {  get; set; }
        public override string ToString()
        {
            return $"{ID} - {FirstName + " " + LastName} - {Salary}";
        }
        public Employee(string Firstname,int salary)
        {
            FirstName = Firstname;
            Salary = salary;
        }
         public Employee(String Firstname,String Depart)
         {
                 this.FirstName = Firstname;
                 this.Department = Depart;
         }
    }
    public class EMPComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            int comarerResult = x.Salary.CompareTo(y.Salary);
            if (comarerResult == 0)
            {
                return x.FirstName.CompareTo(y.FirstName);
            }
            return comarerResult;
        }
    }
    public class EmployeeDto
    {
        public int ID { get; set; }
        public string FullName { get; set; } = null!;
        public override string ToString()
        {
            return $"{ID} - {FullName}";
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public List<string> Programming { get; set; } = new();

    }
    public class Product : IEquatable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string categore { get; set; } 
        public decimal Price { get; set; }
        public Product(string name,string cat,decimal price)
        {
            this.Name = name;
            this.categore = cat;
            this.Price = price;
        }

        public bool Equals(Product? other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            else if (object.ReferenceEquals(this, null))
            {
                return false;
            }
            else if (this.Id == other.Id && this.Name == other.Name && this.Price == other.Price)
            {
                return true;
            }
            return false;
        }

        //public override bool Equals(object? obj)
        //{
        //    if (object.ReferenceEquals(obj, null))
        //    {
        //        return false;
        //    }
        //    else if (object.ReferenceEquals(this, null))
        //    {
        //        return false;
        //    }
        //    else if (obj is Product prod && this.Id == prod.Id && this.Name == prod.Name && this.Price == prod.Price)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public override int GetHashCode()
        {
            int idHashCode = this.Id.GetHashCode();
            int nameHashCode = this.Name.GetHashCode();
            int priceHashCode = this.Price.GetHashCode();
            return idHashCode ^ nameHashCode ^ priceHashCode;
        }
    }
    public interface IPerson
    {
        public Guid Identity { get; set; }
        public string Name { get; set; }
    }
    public interface ISkills
    {
        public List<string> Skills { get; set; }
    }
    public interface IExperiance
    {
        public int ExperianceYears { get; set; }
    }
    public class Developer : IPerson, ISkills
    {
        public Guid Identity { get; set; }
        public string Name { get; set; } = null!;
        public List<string> Skills { get; set; } = new();
    }
    public class Engineer : IPerson, IExperiance
    {
        public Guid Identity { get; set; }
        public string Name { get; set; } = null!;
        public int ExperianceYears { get; set; }
    }
    public class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }
    }
    public class FruitComparer : IEqualityComparer<Fruit>
    {
        public bool Equals(Fruit? x, Fruit? y)
        {
            if (x is null && y is null)
            {
                return true;
            }
            else if ((x is not null && y is null) || (x is null && y is not null))
            {
                return false;
            }
            else if (x.Price == y.Price)
            {
                return true;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] Fruit obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            return obj.Price.GetHashCode();
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public override bool Equals(object? obj)
        {
            if (!(obj is Person))
            {
                return false;
            }
            else if (obj is Person person)
            {
                return this.Id == person.Id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
    public class CollageStudent : IEquatable<CollageStudent>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime GraduationYear { get; set; }
        public static List<CollageStudent> GetStudents()
        {
            List<CollageStudent> students = new List<CollageStudent>()
            {
                new CollageStudent {ID = 101, Name = "yara" ,GraduationYear=new DateTime(2015, 12, 25)},
                new CollageStudent {ID = 102, Name = "tamer" ,GraduationYear=new DateTime(2016, 12, 25)},
                new CollageStudent {ID = 101, Name = "YARa",GraduationYear=new DateTime(2015, 12, 25)},
                new CollageStudent {ID = 104, Name = "ramy",GraduationYear=new DateTime(2018, 12, 25)}
            };
            return students;
        }
        public bool Equals(CollageStudent other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return (this.Name.ToLower() == other.Name.ToLower()) && this.ID == other.ID && this.GraduationYear == other.GraduationYear;
        }
        public override int GetHashCode()
        {
            //invalid to do this => all properties used in equal method should be used in hashcode 
            int NameHashCode = this.Name == null ? 0 : this.Name.ToLower().GetHashCode();
            return NameHashCode;
        }
    }
    public class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            if (object.ReferenceEquals(x, null))
            {
                return false;
            }
            else if (object.ReferenceEquals(y, null))
            {
                return false;
            }
            else if (x.Id == y.Id && x.Name == y.Name && x.Price == y.Price)
            {
                return true;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name.GetHashCode();
            int priceHashCode = obj.Price.GetHashCode();
            return idHashCode ^ nameHashCode ^ priceHashCode;
        }
    }
    public class FruitStatistics
    {
        public int MaxPrice { get; set; } = 0;
        public int MinPrice { get; set; } = 0;
        public int FruitCount { get; set; } = 0;
        public int SumPrice { get; set; } = 0;
        public override string ToString()
        {
            return $"MaxPrice = {MaxPrice} , MinPrice = {MinPrice} , SumPrice = {SumPrice} , FruitCount = {FruitCount}";
        }
    }
    public class PrimaryStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public List<Subject> Subjects { get; set; }
    }
    public class Subject
    {
        public string SubjectName { get; set; }
        public int Marks { get; set; }
    }
    public class SecondryStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Barnch { get; set; }
        public int Age { get; set; }
    }
    public class SecondryStudentDto
    {
        public string BranchName { get; set; }
        public List<string> StudentNames { get; set; }

    }
    public class Order
    {

        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int Price { get; set; }
        public decimal Amount { get; set; }
        public DateTime date {  get; set; }

        public Order(int orderid,int price)
        {
            CustomerId = orderid;
            OrderId = orderid;
        }
        public Order(DateTime date,decimal amount)
        {
            this.date = date;
            this.Amount= amount;
        }
    }
    
    class TestEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
    }
    public class Sale
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public string Name { get; set; }
        public DateTime SaleDate { get; set; }

        public Sale(string salesman , int amount) {
        Name=salesman;
        Amount=amount;
        }
    }
    public class StudentTest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
    }
    public class EmployeeTest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int DepartmentId { get; set; }
        public override string ToString()
        {
            return $"{ID} - {Name}";
        }
    }
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class EmployeeResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public override string ToString()
        {
            return $"{ID} - {Name} - {Department}";
        }

    }
}