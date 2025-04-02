using Console_AccessModifiers;


namespace Console_AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class TestClass_NotAssembly__NotDerived
    {

        public void method()
        {
            VariablesClass._Variable_public = "Accessible";               // Accessible (Any Assembly / Any class)
            VariablesClass._Variable_internal = "Accesible";              // current class isn't in same assembly
            VariablesClass._Variable_protected = "Accessible";            // current class isn't a derived class
            VariablesClass._Variable_protected_internal = "Accesible";    // current class isn't derived class OR current class NOT located in the same assembly
            VariablesClass._Variable_private_protected = "Accesible";   // current class isn't owner class OR current class isn't a derived class
            VariablesClass._Variable_private = "";                      // current class isn't owner class 
        }
    }

    public class TestClass_NotAssembly__Derived : VariablesClass
    {

        public void method()
        {
            VariablesClass._Variable_public = "Accessible";               // Accessible (Any Assembly / Any class)
            VariablesClass._Variable_protected = "Accessible";            // current class is a derived class
            VariablesClass._Variable_protected_internal = "Accesible";    // current class is derived class Despite current class NOT located in the same assembly
            VariablesClass._Variable_internal = "Accesible";              // current class isn't in same assembly
            VariablesClass._Variable_private = "";                      // current class isn't owner class
            VariablesClass._Variable_private_protected = "Accesible";   // current class isn't owner class OR current class isn't a derived class
        }
    }

}