using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaseOfShadow
{
    internal class Boss : Character
    {
        int bossHealth;
        int bossName;
        int damageDone;
        string answer;
        Items usingItem = new Items();
        public void initBoss()
        {
            this.nameOfChar = "Shadow Demon";
            this.bossHealth = 100;
            this.armor = 50;
            Console.WriteLine("\n" + "Осторожно! Великий демон пробудился!");
            Console.WriteLine($"Имя: {this.bossName}, Здоровье: {this.bossHealth}, Броня: {this.armor}" + "\n");
        }
        public void initBossFight()
        {
            while (true)
            {
                Console.WriteLine("Демон выжидает. Что вы будете делать?");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "Might":
                        useMight();
                        Console.WriteLine($"Вы нанесли демону урон равный - {damageDone} единицам\nУ {bossName} осталось {bossHealth} единиц здоровья");
                        break;
                }
                if (bossHealth <= 0) 
                {
                    Console.WriteLine($"Поздравляем, вы победили {bossName}");
                    Console.ReadKey();
                    break;
                }
                
            }
        }


        public void useMight()
        {
            Console.WriteLine("Вы взмахиваете мечом и бьете противника!");
            Console.WriteLine(usingItem.itemInHand[2]);
            damageDone = Convert.ToInt32(usingItem.itemInHand[2]);
            bossHealth -= damageDone;
        }

        public void useDodge()
        {

        }
    }
}
