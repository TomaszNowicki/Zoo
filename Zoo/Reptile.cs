using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Reptile : Animal
    {
        public string skin { get; set; }


        public Reptile()

        {
            skin = "nieznane";
        }

        public Reptile(string name, int age, double weight, string skin)
             : base(name, age, weight)
        {
            this.skin = skin;
        }

        public void CreateReptile()
        {
            //Reptile reptile = new Reptile();

            Console.WriteLine("Podaj Imie: ");
            name = Console.ReadLine();
            Console.WriteLine("Podaj Wiek: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Wagę: ");
            weigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj kolor skory: ");
            skin = Console.ReadLine();
            Console.WriteLine("\n\nWcisnij jakis klawisz aby powrocic do menu");
            ToString();


        }
        public override string ToString() => "Imie: " + name + "\nWiek: " + age + "\nWaga: " + weigth + "\nKolor skory: " + skin;

    }



}
