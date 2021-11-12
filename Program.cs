using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystalPrice = 5;
            int crystalCount;

            Console.WriteLine("Добро пожаловать в обменник! У нас самый выгодный курс, кристал стоит " + crystalPrice + " золота.");
            Console.Write("Сколько у вас золота: ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько вам нужно кристалов: ");
            crystalCount = Convert.ToInt32(Console.ReadLine());

            gold -= crystalCount * crystalPrice;

            Console.WriteLine("Вы купили " + crystalCount + " кристала, у вас осталось " + gold + " золота.");
        }
    }
}