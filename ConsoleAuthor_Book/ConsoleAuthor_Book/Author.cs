using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAuthor_Book
{
    public class Author
    {
         private string Name;
        private string Email;
        private char Gender;

        public Author(string name, string email, char gender)
        {
            this.Name = name;
            this.Gender = gender;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public char getGender()
        {
            return this.Gender;
        }
        public void setEmail(string newmail)
        {
            this.Email = newmail;
        }
        //override
        public override string ToString()
        {

            return String.Format("Author[name={0}, email={1}, gender={2}]", this.Name, this.Email, this.Gender);
        }
    }
}
