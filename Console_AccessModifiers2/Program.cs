using Console_AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console_AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class AccessTestClass_B : VariablesClass
    {
        VariablesClass v1 = new VariablesClass();

        AccessTestClass_B b1 = new AccessTestClass_B();

        public void method()
        {
            v1._Variable_public= "Accessible";  // Not Same assembly but Is another assembly
            // v1._Variable_internal             Access denied !  Not Same Assembly
            // v1._Variable_protected_internal   Access denied !  NOT Derived Class -OR- NOT Same Assembly 
            // v1._Variable_private;             Access denied !  NOT Same Class
            // v1._Variable_protected            Access denied !  NOT Derived Class 
            // v1._Variable_private_protected;   Access denied !  Work only in Same Assemblies
            
            b1._Variable_public= "Accessible";     // Not Same assembly but Is another assembly
            b1._Variable_protected = "Accessible"; // Is Drived Class (even parent is in another assembly)
            b1._Variable_protected_internal= "Accessible"; // Not Same assembly (internal) -BUT- Drived Class (protected)        
        }
    }
}