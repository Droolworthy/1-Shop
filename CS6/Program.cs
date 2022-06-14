using System;

namespace CS6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialamountGold;
            int numberСrystals;
            int crystalPrice = 10;
            bool enoughMoney;
            Console.Write("Введите кол-во золота: ");
            initialamountGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Предлагаю вам купить 10 кристаллов по цене 10 золота за штуку: ");
            numberСrystals = Convert.ToInt32(Console.ReadLine());
            enoughMoney = initialamountGold >= numberСrystals * crystalPrice;
            numberСrystals *= Convert.ToInt32(enoughMoney);
            initialamountGold -= numberСrystals * crystalPrice;
            Console.WriteLine("Поздравляю! Вы приобрели: " + numberСrystals + " кристаллов");
            Console.WriteLine("У вас осталось: " + initialamountGold + " золота");
        }
    }
}
