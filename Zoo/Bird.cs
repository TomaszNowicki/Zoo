using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Bird : Animal
    {
        public string feather { get; set; }


        public Bird()

        {
            feather = "nieznane";
        }

        public Bird(string name, int age, double weight, string feather)
             : base(name, age, weight)
        {
            this.feather = feather;
        }

        public void CreateBird()
        {
            Console.WriteLine("Podaj Imie: ");
            name = Console.ReadLine();
            Console.WriteLine("Podaj Wiek: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Wagę: ");
            weigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj Kolor pior: ");
            feather = Console.ReadLine();
            ToString();
            Console.WriteLine("\n\nWcisnij jakis klawisz aby powrocic do menu");


        }
        public override string ToString() => "Imie: " + name + "\nWiek: " + age + "\nWaga: " + weigth + "\nKolor pior: " + feather;

    }
}
