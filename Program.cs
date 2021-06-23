using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ?? returns the value of its left-hand operand if it isn't null;
// otherwise, it evaluates the right-hand operand and returns its result.
// The ?? operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.

namespace ThrownExpression
{
    //this feature is for whenever i wanted to raise an exception,, it is easy to handle even from the exception

    class Demo
    {
        //2 properties
        public string firstname { get; set; }
        public string lastname { get; set; }

        //create constructor of class
        public Demo(string fname, string lname)
        {
            //fname is not null otherwise throw  new ArgumentNullException where parameter name is name of _
            firstname = fname ?? throw new ArgumentNullException(paramName: nameof(fname));
            lastname = lname ?? throw new ArgumentNullException(paramName: nameof(lname));

        }
    }
    class Program
    {
        static void Main()
        {
            //instantiate it
            Demo dd = new Demo("roshi", null); //keeping the other value(lname) as null
            //now display the values
            Console.WriteLine($"{dd.firstname}, {dd.lastname}");
            Console.ReadKey();

        }
     
        //output = it throws an error that value cannot be null
    }
}
