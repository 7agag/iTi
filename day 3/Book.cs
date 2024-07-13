using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace iTi
{
    class Book1
    {
        int id, price;
        string name, category; 
        DateTime created_on; 
        bool isdeleted;
        public  static int Count = 0;

        public Book1(int Id, int Price = 250)
        {
            this.id = Id;
            this.price = Price;
            Count++;


        }
        public Book1(int id, string name, string category, bool isdel,int price = 250)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.price = price;
            this.isdeleted = isdel;
            Count++;

        }
        public Book1(int id, string name, string category, DateTime creat, bool isdel, int Price = 250)
        {
            this.id = id;
            this.name = name;
            this.category= category;
            this.price = price;
            this.created_on = creat;
            this.isdeleted = isdel;
            Count++;

        }
        static Book1()
        { 
            Console.WriteLine("Hello to Book Shop ^~^");
             
            
        }

        public bool IssDeleted()
        {
            isdeleted =! isdeleted;
            return false;

        }
        
        
        public void getdata()
        {
            Console.WriteLine($"{name} --- {name} --- {category} --- {price} --- {created_on} --- {Count} ");
        }



    }
    internal class Book
    {
        public static void Main(string[] args)
        {
            Book1 bk1 = new Book1(1,"Mohamed Ali ", "Historcial",true,200);
            Book1 bk2 = new Book1(3, "El Feel AL Azraq", "Mystery",false);
            Book1 bk3 = new Book1(2, "Longman", "Eduaction", true, 150);
            bk1.IssDeleted();
            bk2.IssDeleted();
            bk3.IssDeleted();
            bk1.getdata();
            bk2.getdata();
            bk3.getdata();





        }
    }
}
//book    how many book buy , 
