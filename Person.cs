using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6._2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            if (this.Age == 0) return "Name: " + Name + " Age not specified!";
            else
                return "Name: " + Name + "Age:" + Age;
        }
    }
}
