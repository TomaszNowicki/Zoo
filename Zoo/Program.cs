using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
       
        

        public static void printAnimals(List<Animal> animals) // metoda wypisujace elementy listy
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();      // deklaracja listy obiektów

            bool exit = false; // zapętlenie menu
            while (!exit)
            {
               
            
                Console.WriteLine("**MENU**\nWcisnij: \n1.Dodaj zwierze.\n2.Pokarz liste zwierzat. \n3.posortuj liste po wieku\n4.Exit ");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                            Console.WriteLine("Press a key for: \n1.Ssak \n2.Gad \n3.Ptak\n");
                            int subMenu = int.Parse(Console.ReadLine());                      // pod menu
                        {
                            if (subMenu == 1) // tworzenie obiektu ssak
                            {
                                Mammal mammal = new Mammal();
                                mammal.CreateMammal();
                                Console.WriteLine("\n\nTwoj ssak:\n" + mammal.ToString());
                                animals.Add(mammal);
                            }
                            if (subMenu == 2)  // tworzenie obiektu gad
                            {
                                Reptile reptile = new Reptile();
                                reptile.CreateReptile();
                                Console.WriteLine("\n\nTwoj gad:\n" + reptile.ToString());
                                animals.Add(reptile);
                            }
                            if (subMenu == 3)  // tworzenie obiektu ptak
                            {
                                Bird bird = new Bird();
                                bird.CreateBird();
                                Console.WriteLine("\n\nTwoj ptak:\n" + bird.ToString());
                                animals.Add(bird);
                            }
                            if (subMenu > 3)
                            {
                                Console.WriteLine("Niepoprawny wybor, wcisnij jakis klawisz aby powrocic do menu");
                            }

                            break;
                        }

                    case 2:
                        printAnimals(animals);
                        break;

                    case 3:
                        //animals.Sort((x, y) => x."name" - y."name");  // algorytm sortowania
                        //printAnimals(animals);
                        var orderedAnimals = animals.OrderBy(x => x.name);
                        printAnimals(animals);




                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Niepoprawny wybor, wcisnij jakis klawisz aby powrocic do menu");
                        break;

                }


                System.Console.ReadKey();
            }
        }

    }
    

   
}
