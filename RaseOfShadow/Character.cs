using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaseOfShadow
{
    internal class Character
    {
        public string nameOfChar;
        public int health;
        public int armor;
        Random rand = new Random();


        public void createChar()
        {
            Console.WriteLine("Хотите создать персонажа вручную?");
            Console.WriteLine("Нажмите Y - для создания вручную, N - для случайных характеристик");
            char answer;
            while (true)
            {
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'y')
                {
                    setCharStats();
                    printCharStats(nameOfChar, health, armor);
                    break;
                }
                else if (answer == 'n')
                {
                    Console.WriteLine("Персонаж будет создан случайно!");
                    Console.Write("Введите имя для вашего персонажа: ");
                    nameOfChar = Console.ReadLine();
                    setRandomCharStats();
                    Console.WriteLine("Поздравляем, вот характеристики вашего персонажа:");
                    printCharStats(nameOfChar, health, armor);
                    break;
                }
            }
        }
        
        public void setCharStats()
        {
            Console.Write("Введите имя: ");
            this.nameOfChar = Console.ReadLine();
            Console.Write("Введите количество здоровья: ");
            this.health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите показатель брони: ");
            this.armor = Convert.ToInt32(Console.ReadLine());

        }

        public void setRandomCharStats()
        {
            this.health = rand.Next(90,110);
            this.armor = rand.Next(40,60);
        }
        
        public void printCharStats(string name, int health, int armor)
        {
            Console.WriteLine("\n" + $" Имя: { this.nameOfChar} \n Здоровье: {this.health} \n Броня: {this.armor} \n");
        }


    }
}
