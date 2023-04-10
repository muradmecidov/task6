using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.NewFolder
{


    internal record Dog : Animal
    {
        public string Name;
        public string Breed;

     
        public Dog(string name, string breed, string Gender) : base(Gender)
        {
            Name = name;
            Breed = breed;
        }

       
    }
}
