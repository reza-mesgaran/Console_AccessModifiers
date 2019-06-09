using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_AccessModifiers
{
    public  class VariablesClass
    {
        // we have 6 access modifiers
         public string _Variable_public;          // Accessible from everywhere (Same/Other Assembly)
         private string _Variable_private;        // Accessible from same class or struct.
         protected string _Variable_protected;    // Accessible from same class / derived class
         internal string _Variable_internal;     // Accessible from ONLY same assembly,(not another assembly)
         protected internal string _Variable_protected_internal; //Accessible from same assembly / drived class in another assembly
         private protected string _Variable_private_protected;   //Accessible from  the same class (in same Assembly) / drived class (in same Assembly)

        static void Main(string[] args)
        {
            
        }
    }

   public class AccessTestClass
    {
        public void method()
        {
            VariablesClass v1 = new VariablesClass();
            
            v1._Variable_public = "Accessible";   //Accessible -  Same Assembly
            v1._Variable_internal = "Accessible"; //Accessible -  Same Assembly
            v1._Variable_protected_internal = "Accessible"; //Accessible -  Same Assembly
            // v1._Variable_private;             Access denied ! (Not Same Class)
            // v1._Variable_protected            Access denied ! (Not Same Class / Not a Drived Class)
            // v1._Variable_private_protected;   Access denied !  (Not Same Class/Not a Drived Class)
        }
    }

    public class AccessTestClass2: VariablesClass
    {
        public void method()
        {
            VariablesClass v1 = new VariablesClass();           
        }
    }
}