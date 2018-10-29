using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker firstWorker = new Worker("Tazhibek", "Aknur"); 
            Worker secondWorker = new Worker("Abdimash", "Dimash"); 
            Worker thirdWorker = new Worker("Abdishev", "Miras"); 
            Worker fourthWorker = new Worker("Orazbekova", "Balym"); 
            Worker fifthWorker = new Worker("Asmiyeva", "Inkara");

            List<Worker> workers = new List<Worker>(){ firstWorker, secondWorker, thirdWorker, fourthWorker, fifthWorker }; 
            Team team = new Team(workers);
            House house = new House();

            
            
             
            List<Wall> walls = new List<Wall>();
            List<Window> windows = new List<Window>();
            while (true)
            {
                Console.WriteLine("Выберите: ");
                Console.WriteLine("1 - Постройка дома ");
                Console.WriteLine("2 - Отчет ");
                Console.WriteLine("3 - Выход ");

                string chooseMenu = Console.ReadLine();
                if (int.Parse(chooseMenu) == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Построено: ");

                    Console.WriteLine(house.Walls.Count + " - стен ");
                    Console.WriteLine(house.Windows.Count + " - окон ");
                    Console.WriteLine(Roof.count + " - крыш ");
                    Console.WriteLine(Basement.count + " - фундаментов ");
                    Console.WriteLine(Door.count + " - дверей");


                    Console.WriteLine("Что строить: ");
                    Console.WriteLine(1 + " - стенa ");
                    Console.WriteLine(2 + " - окно ");
                    Console.WriteLine(3 + " - крыша ");
                    Console.WriteLine(4 + " - фундамент ");
                    Console.WriteLine(5 + " - дверь");

                    string chooseMenuBuild = Console.ReadLine();

                    if (int.Parse(chooseMenuBuild) == 1 )
                    {
                        Wall wall = new Wall("Material", 100, 100, 25000);
                        house.AddWall(wall);
                        Console.WriteLine("Стена построена!");
                    }
                    else if (int.Parse(chooseMenuBuild) == 2)
                    {
                        Window window = new Window("Material", 100, 100, 25000);
                        house.AddWindow(window);
                        Console.WriteLine("Окно построено!");
                    }
                    else if (int.Parse(chooseMenuBuild) == 3)
                    {
                        Roof roof = new Roof("MaterialName", 100, 100, 50000);
                        house.Roof = roof;
                        Console.WriteLine("Крыша построена!");
                    }
                    else if (int.Parse(chooseMenuBuild) == 4)
                    {
                        Basement basement = new Basement("MaterialName", 100, 100, 50000);
                        house.Basement = basement;
                        Console.WriteLine("Фундамент построен!");
                    }
                    else if (int.Parse(chooseMenuBuild) == 5)
                    {

                        Door door = new Door("MaterialName", 100, 100, 50000);
                        house.Door = door;
                        Console.WriteLine("Дверь построена!");
                    }
                    else {
                        Console.WriteLine("Введите число 1-5");
                    }

                    Console.ReadLine();
                }

                else if (int.Parse(chooseMenu) == 2)
                {
                    if (house.Walls.Count >= 4 && house.Windows.Count >= 4 && Roof.count >= 1 && Basement.count >= 1 && Door.count >= 1)
                    {
                        string domik = @"
                    
                    ___________________    
                   /\        ______    \   
                  //_\       \    /\    \  
                 //___\       \__/  \    \
                //_____\       \ |[]|     \
               //_______\       \|__|      \
              /XXXXXXXXXX\                  \
             /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";

                        Console.WriteLine(domik);
                    }
                    else
                    {
                        Console.WriteLine("Дом еще не достроен! ");

                    }
                    Console.ReadLine();
                }
                else if (int.Parse(chooseMenu) == 3)
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Введите число 1-3! ");
                    Console.ReadLine();
                }
                Console.Clear();

                //Console.WriteLine(" ");
                //Console.WriteLine(" ");


            }
        }
    }
}
