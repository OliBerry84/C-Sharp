using System;

namespace Datatypes_NamingConventions
{   // Class names like ClientActivity - Pascal case only
    class Program
    {
           // Method name like CalculateValues
           // method arguments like firstNumber
        static void Main(string[] args)
        {
            // local variables like itemCount

            // Try to avoid abbreviations.... userControl instead of usrCtrl

            // Don't use numbers at the start of variables... int 3cars = 5; BAD int cars3 = 5; GOOD
            // Try to avoid the underscore unless it is at the start e.g. _loginDate 

            // Avoid String Int32 Boolean
            
            //Correct are below
            string myName;
            int lastNum;
            bool isSaved;

            //www.dofactory.com/reference/csharp-coding-standards
        }
    }
}
