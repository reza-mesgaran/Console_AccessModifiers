using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Note : when we talk about Access Modifiers,We talk about access to members of class in the another Class

namespace Console_AccessModifiers
{
    public class VariablesClass
    {
        // We have 6 access modifiers
        static public string _Variable_public;          // Accessible from everywhere (Same/Other Assembly)
        static private string _Variable_private;        // Accessible from same class or struct.
        static protected string _Variable_protected;    // Accessible from same class / derived class
        static internal string _Variable_internal;     // Accessible from ONLY same assembly,(not another assembly)
        static protected internal string _Variable_protected_internal; //Accessible from same assembly OR drived class in another assembly
        static private protected string _Variable_private_protected;   //Accessible from  the same class (in same Assembly) OR drived class (in same Assembly)

        static void Main(string[] args)
        {

        }
    }

    public class TestClass_SameAssembly_NotDerived 
    {
        public void method()
        {
            VariablesClass._Variable_public = "Accessible";               // Accessible (Any Assembly / Any class)
            VariablesClass._Variable_internal = "Accesible";              // current class is in same assembly
            VariablesClass._Variable_protected_internal = "Accesible";    //current class isn't derived BUT current class located in the same assembly (one condition is enough)
            VariablesClass._Variable_protected="Accessible";           // current class isn't derived class
            VariablesClass._Variable_private = "";              // current class isn't owner class 
           VariablesClass._Variable_private_protected = "Accesible";    
        }
    }

    public class TestClass_SameAssembly_Derived :VariablesClass
    {
        public void method()
        {
            VariablesClass._Variable_public = "Accessible";               // Accessible (Any Assembly / Any class)
            VariablesClass._Variable_internal = "Accesible";              // current class is in same assembly
            VariablesClass._Variable_protected = "Accessible";            // current class is a derived class
            VariablesClass._Variable_protected_internal = "Accesible";    // current class isn't derived class also current class located in the same assembly
            VariablesClass._Variable_private_protected = "Accesible";   // current class isn't owner class BUT current class is a derived class
            VariablesClass._Variable_private = "";                      // current class isn't owner class 
        }
    }




}