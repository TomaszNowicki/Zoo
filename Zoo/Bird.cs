using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Bird : Animal
    {
        public string Feather { get; set; }


        public Bird()

        {
            Feather = "nieznane";
        }

        public Bird(string Name, int Age, int Weight, string Feather)
             : base(Name, Age, Weight)
        {
            this.Feather = Feather;
        }

        public void CreateBird()
        {
            Bird bird = new Bird();

            Console.WriteLine("Podaj Imie: ");
            Name = Console.ReadLine();
            Console.WriteLine("Podaj Wiek: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Wagę: ");
            Weigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Kolor pior: ");
            Feather = Console.ReadLine();
            ToString();


        }
        public override string ToString() => "Imie: " + Name + "\nWiek: " + Age + "\nWaga: " + Weigth + "\nKolor pior: " + Feather;

    }
}
