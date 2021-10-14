using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWK4
{
     class Globals
    {
        private List<Person> _people;
        public Globals()
        { _people = new List<Person>(); }
        public List<Person> People { 
            get => _people;
            set => _people = value;
        }
    }
}
