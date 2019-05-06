using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Mammal : Animal
    {
        public string FurColour { get; set; }


        public Mammal()

        {
            FurColour = "nieznane";
        }

        public Mammal(string Name, int Age, int Weight, string FurColour)
             : base(Name, Age, Weight)
        {
            this.FurColour = FurColour;
        }

        public void CreateMammal()
        {
            Mammal mammal = new Mammal();

            Console.WriteLine("Podaj Imie: ");
            Name = Console.ReadLine();
            Console.WriteLine("Podaj Wiek: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Wagę: ");
            Weigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Kolor Futra: ");
            FurColour = Console.ReadLine();
            ToString();
            
        
        }
        public override string ToString() => "Imie: " + Name + "\nWiek: " + Age + "\nWaga: " + Weigth + "\nKolor Futra: " + FurColour;
    }
}



   
    
    

   


