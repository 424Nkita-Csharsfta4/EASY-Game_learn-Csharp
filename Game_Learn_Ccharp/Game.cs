using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game_Learn_Ccharp
{
    class Game
    {
        public void Start()
        {
            WriteLine("Игра начинается");

            ConsoleKeyInfo keyInfo = ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                WriteLine("Вы нажали Enter");
            }
            else
            {
                WriteLine();
            }

            WriteLine("Нажмите любую клавишу для выхода");
            ReadKey(true);
        }
    }
}
