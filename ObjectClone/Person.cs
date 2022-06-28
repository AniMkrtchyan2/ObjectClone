using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectClone
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        // Copy Constructor
        public Person(Person other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
        }
        #region ICloneable Members
        // Type safe Clone
        public Person Clone() 

        { 
            return new Person(this);
        }
      
        // ICloneable implementation
        object ICloneable.Clone()
        {
            return Clone();
        }
        #endregion
    }
}
