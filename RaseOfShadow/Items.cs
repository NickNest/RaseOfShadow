using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaseOfShadow
{
    internal class Items
    {
        public string nameOfItem;
        public int priceOfItem;
        public int damageOfItem;
        public string[] itemInHand = new string[3];


        public void buyItem()
        {

        }


        public void takeItem()
        {

        }

        public void useItem()
        {
            Console.WriteLine(itemInHand[2]);
        }
    }
}
