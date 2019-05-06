using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
                

            Mammal mammal = new Mammal();
            Bird bird = new Bird();
            Reptile reptile = new Reptile();


            int Menu = Convert.ToInt32(Console.ReadLine());

            switch (Menu)
            {
                case 1:
                    Console.WriteLine("Wybierz a,b,c ");
                    char subMenu = Convert.ToChar(Console.ReadLine());
                    switch (subMenu)
                    {
                        case 'a':
                            mammal.CreateMammal();
                            break;
                        case 'b':
                            bird.CreateBird();
                            break;
                        case 'c':
                            reptile.CreateReptile();
                            break;
                    }
                    break;

                case 2:
                   
                    break;

                case 3:
                    reptile.CreateReptile();
                    break;
            }
            

            System.Console.ReadKey();

        }

    }
    

   
}
