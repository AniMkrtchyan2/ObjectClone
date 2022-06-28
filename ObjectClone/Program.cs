using System;
using System.Diagnostics;

namespace ObjectClone
{
    class Program
    {
        public static void Main(String[] args)
        {
            Person bob = new Person("Bob", 25);
            Person bob_clone = bob.Clone();
            Debug.Assert(bob_clone.Name == bob.Name);
            bob.Age = 56;
            Debug.Assert(bob.Age != bob.Age);
            Console.WriteLine(bob.Age);
            Console.WriteLine(bob.Name);
        }
    }
}

