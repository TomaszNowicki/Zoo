using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Mammal : Animal
    {
        public string furColour { get; set; }


        public Mammal()

        {
            furColour = "nieznane";
        }

        public Mammal(string name, int age, double weight, string furColour)
             : base(name, age, weight)
        {
            this.furColour = furColour;
        }

        public void CreateMammal()
        {        
            Console.WriteLine("Podaj Imie: ");
            name = Console.ReadLine();
            Console.WriteLine("Podaj Wiek: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Wagę: ");
            weigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj Kolor Futra: ");
            furColour = Console.ReadLine();
            Console.WriteLine("\n\nWcisnij jakis klawisz aby powrocic do menu");
            ToString();
            
        
        }
        public override string ToString() => "Imie: " + name + "\nWiek: " + age + "\nWaga: " + weigth + "\nKolor Futra: " + furColour;
    }
}



   
    
    

   


