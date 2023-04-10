using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.NewFolder
{
    internal record Animal
    {
        public string Gender;
        public int BirthYear;

        public Animal(string gender)
        {
            Gender = gender;
            BirthYear = 2023;
        }







    }
}

