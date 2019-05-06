using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weigth { get; set; }



        public Animal()
        {
            Name = "nieznane";
            Age = 0;
            Weigth = 0;
        }
        
        public Animal(string Name,int Age, int Weigth)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weigth = Weigth;
        }

        

    }// class end
}
