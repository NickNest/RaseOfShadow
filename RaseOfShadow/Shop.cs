using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaseOfShadow
{
    internal class Shop : Items
    {
        string answer;
        string[] nameOfItems = { "WindBraker", "Maelstorm", "StaminHolder", "IronMight" };
        //int priceOfItem;
       // int damageOfItem;
        char choiceOfPlayer;
        public int numberOfItems = 4;
        int count;
        List<string> listOfShopItems = new List<string>();
        //string[] itemInfo = new string[3];
        Random rand = new Random();

        public void initShop()
        {
            Console.Clear();            
            Console.WriteLine($"Вы заходите в лавку и видите на полке {numberOfItems} предмета \n");
            for (int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine((i + 1) + " предмет: ");
                listOfShopItems.Add(nameOfItems[i]);
                listOfShopItems.Add(System.Convert.ToString(this.priceOfItem = rand.Next(10, 21)));
                listOfShopItems.Add(System.Convert.ToString(this.damageOfItem = rand.Next(17, 30)));
                Console.WriteLine(nameOfItems[i] + " с ценой " + this.priceOfItem + " монет " + "и уроном " + this.damageOfItem + " единиц \n");
            }
            Console.WriteLine("Какой предмет хотите купить?");
            choiceOfPlayer = System.Convert.ToChar(Console.ReadLine());

            switch (choiceOfPlayer)
            {
                case '1':
                    for (int i = 0; i < 3; i++)
                    {
                        itemInHand[i] = this.listOfShopItems[i];
                    }
                    break;
                case '2':
                    for (int i = 0; i < 3; i++)
                    {
                        itemInHand[i] = this.listOfShopItems[i + 3];
                    }
                    break;
                case '3':
                    for (int i = 0; i < 3; i++)
                    {
                        itemInHand[i] = this.listOfShopItems[i + 6];
                    }
                    break;
                case '4':
                    for (int i = 0; i < 3; i++)
                    {
                        itemInHand[i] = this.listOfShopItems[i + 9];
                    }
                    break;
            }
            Console.WriteLine($"Поздравляем! Вы купили {itemInHand[0]}");
            Console.WriteLine("Хотите остаться и купить еще что-нибудь?\nY - остаться, Любой текст - назад в лобби");
            answer = Console.ReadLine();
            if (answer == "Y" || answer == "y") stayShop();
        }
        public void stayShop()
        {
            Console.Clear();            
            Console.WriteLine($"Вы стоите в лавке и видите на полке {numberOfItems} предмета \n");
            for (int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine((i + 1) + " предмет: ");
                Console.WriteLine(nameOfItems[i] + " с ценой " + this.priceOfItem + " монет " + "и уроном " + this.damageOfItem + " единиц \n");
            }
            Console.WriteLine("Какой предмет хотите купить?");
            choiceOfPlayer = System.Convert.ToChar(Console.ReadLine());

            switch (choiceOfPlayer)
            {
                case '1':
                    for (int i = 0; i < 3; i++)
                    {
                        this.itemInHand[i] = this.listOfShopItems[i];
                    }
                    break;
                case '2':
                    for (int i = 0; i < 3; i++)
                    {
                        this.itemInHand[i] = this.listOfShopItems[i + 3];
                    }
                    break;
                case '3':
                    for (int i = 0; i < 3; i++)
                    {
                        this.itemInHand[i] = this.listOfShopItems[i + 6];
                    }
                    break;
                case '4':
                    for (int i = 0; i < 3; i++)
                    {
                        this.itemInHand[i] = this.listOfShopItems[i + 9];
                    }
                    break;
            }
            Console.WriteLine($"Поздравляем! Вы купили {itemInHand[0]}");
            Console.WriteLine("Хотите остаться и купить еще что-нибудь?\nY - остаться, Любой текст - назад в лобби");
            answer = Console.ReadLine();
            if (answer == "Y" || answer == "y") stayShop();
        }
    }
}
