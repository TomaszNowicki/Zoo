using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public double weigth { get; set; }



        public Animal()
        {
            name = "nieznane";
            age = 0;
            weigth = 0;
        }
        
        public Animal(string name,int age, double weigth)
        {
            this.name = name;
            this.age = age;
            this.weigth = weigth;
        }

        

    }// class end
}
