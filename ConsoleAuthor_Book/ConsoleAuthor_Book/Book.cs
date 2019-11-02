using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAuthor_Book
{
    public class Book
    {
        private string Name;
        private Author[] Authors;
        private double Price;
        private int Qty = 0;

        public Book(string name, Author[] authors, double price, int qty = 0)
        {
            this.Name = name;
            this.Price = price;
            this.Authors = authors;
            this.Qty = qty;
        }
        public string getName()
        {
            return this.Name;
        }
        public double getPrice()
        {
            return this.Price;
        }
        public void setPrice(double price)
        {
            this.Price = price;
        }
        public int getQty()
        {
            return this.Qty;
        }
        public void setQty(int qty)
        {
            this.Qty = qty;
        }
        public Author[] getAuthors()
        {
            return this.Authors;
        }
        public override string ToString()
        {
            string[] strAuthor = new String[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
                strAuthor[i] = this.Authors[i].ToString();

            return String.Format("book[name={0},{1},author = {{{1}}} ,price={2},qty={3}]", this.Name, this.Authors, this.Price, this.Qty);
        }
        ///tan dung class Author
        //public string GetAuthorName() { return this.Author.getName(); }
        //public string GetAuthorEmail() { return this.Author.getEmail(); }
        //public char GetAuthorGender()  { return this.Author.getGender(); }

        public string GetAuthorNames()
        {
            string[] strAuthorNames = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
            {
                strAuthorNames[i] = this.Authors[i].getName();
            }
            return String.Join(",", strAuthorNames);
        }

    }
}
