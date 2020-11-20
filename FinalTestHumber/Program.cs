using System;

namespace FinalTestHumber
{
    class Person  // Base class (parent) 
    {
        public void PersonName()
        {
            Console.WriteLine("Person Name");
        }
    }

    class Adult : Person  // Derived class (child) 
    {
        public void FirstName()
        {
            Console.WriteLine("first name :Adult");
        }
        public void LastName()
        {
            Console.WriteLine("Last Name :Adult");
        }

    }
    class Child : Person  // Derived class (child) 
    {
        public void FirstName()
        {
            Console.WriteLine("First Name :Child");
        }
        public void LastName()
        {
            Console.WriteLine("Last Name Child");
        }

    }
}

