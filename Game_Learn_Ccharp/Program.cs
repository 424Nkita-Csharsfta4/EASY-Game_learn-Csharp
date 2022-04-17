using System;
using static System.Console;
using System.Threading;
using System.Threading.Tasks;

namespace Game_Learn_Ccharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vot();
        }
        public void Ni()
        {
            Vot();
        }
        public static void Vot(){
           
         

            string headerText = @"
  _    _                 _          _                              _____  _  _   
 | |  | |               | |        | |                            / ____|| || |_ 
 | |__| | _____      __ | |_ ___   | |     ___  __ _ _ __ _ __   | |   |_  __  _|
 |  __  |/ _ \ \ /\ / / | __/ _ \  | |    / _ \/ _` | '__| '_ \  | |    _| || |_ 
 | |  | | (_) \ V  V /  | || (_) | | |___|  __/ (_| | |  | | | | | |___|_  __  _|
 |_|  |_|\___/ \_/\_/    \__\___/  |______\___|\__,_|_|  |_| |_|  \_____||_||_|  
                                                                                
";
            

            Console.Clear();

            // Setup the menu
            ConsoleMenu mainMenu = new ConsoleMenu();

            ConsoleMenu subMenu1 = new ConsoleMenu("==>");
            subMenu1.SubTitle = "---------------- Secret Menu -----------------";
            subMenu1.addMenuItem(0, "backToMain", subMenu1.hideMenu);
            subMenu1.ParentMenu = mainMenu;

            mainMenu.Header = headerText;
            subMenu1.Header = mainMenu.Header;

            mainMenu.SubTitle = "-------------------- Menu ----------------------";
            mainMenu.addMenuItem(0, "Начать", HelloWorld);
            mainMenu.addMenuItem(1, "Список уровней", subMenu1.showMenu);
            mainMenu.addMenuItem(2, "Exit", Exit);
            mainMenu.addMenuItem(3, "Создатель", Razrab);
            // Display the menu
            mainMenu.showMenu();


        }


        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void HelloWorld()
        {
            LVL_Game lVL_Game = new LVL_Game();
            lVL_Game.Opisanie();
            Console.ReadKey(true);
           
        }
        public static void Razrab()
        {
            Clear();
         
            string h = "Мошой Никита (213гр)"+ "\nМое имя нельзя скипнуть:)";

            int time = 50;
            int posX = 0;
            int posY = 50;

            while (true)
            {
                Console.Clear();
                if (posX > 40 || posY < 0) break;

                Console.SetCursorPosition(posX, posY);
                Console.Write(h);

                Thread.Sleep(time);

                posX++;
                posY--;
               
            }
           


           
        }
         
    }
 }

