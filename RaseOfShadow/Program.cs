using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RaseOfShadow
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string answer;
            bool count = false;
            Character player = new Character();
            Boss shadowDemon = new Boss();
            Shop shop = new Shop();
            Items item = new Items();
            /*if (count == false)
            {
                player.createChar();
                count = true;
            }*/
            
            while (true)
            {
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Вы стоите посреди лобби, справа мигает вывеска «HeroShop», судя по всему магазин с вооружением. " +
                "Впереди вас огромные ворота, за которыми располагается арена для битв.");
                Console.WriteLine("Введите «Shop», чтобы отправиться в магазин. Введите «Arena» чтобы отправиться на арену.");
                Console.ForegroundColor= ConsoleColor.White;
                        item.useItem();

                answer = Console.ReadLine();
                switch (answer)
                {
                    case "Shop":
                        shop.initShop();
                        break;
                    case "Arena":
                        shadowDemon.initBoss();
                        Console.WriteLine("Хотите ли вы биться с боссом?");
                        answer = Console.ReadLine();
                        if (answer == "Yes")
                            shadowDemon.initBossFight();
                        else if (answer == "No") break;
                        break;
                }

            }

            //shadowDemon.initBoss();

        }
    }
}
