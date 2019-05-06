using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Reptile : Animal
    {
        public string Skin { get; set; }


        public Reptile()

        {
            Skin = "nieznane";
        }

        public Reptile(string Name, int Age, int Weight, string Skin)
             : base(Name, Age, Weight)
        {
            this.Skin = Skin;
        }

        public void CreateReptile()
        {
            Reptile reptile = new Reptile();

            Console.WriteLine("Podaj Imie: ");
            Name = Console.ReadLine();
            Console.WriteLine("Podaj Wiek: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Wagę: ");
            Weigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj kolor skory: ");
            Skin = Console.ReadLine();
            ToString();


        }
        public override string ToString() => "Imie: " + Name + "\nWiek: " + Age + "\nWaga: " + Weigth + "\nKolor skory: " + Skin;

    }



}
