using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int Test1Score { get; set; }
        public int Test2Score { get; set; }

        public override string ToString()
        {
            return FirstName + " " +
            LastName + " " + Id.ToString() +
            " " + Test1Score.ToString() +
           " " + Test2Score.ToString();
        }
        public int CompareTo(Student other)
        {
            return this.Test1Score.CompareTo(other.Test1Score);
        }
    }

}
