using System;

namespace CS6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialamountGold;
            int amountGold;
            int crystalPrice = 10;
            bool enoughMoney;
            Console.Write("Введите кол-во золота: ");
            initialamountGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Предлагаю вам купить 10 кристаллов по цене 10 золота за штуку: ");
            amountGold = Convert.ToInt32(Console.ReadLine());
            enoughMoney = initialamountGold >= amountGold * crystalPrice;
            amountGold *= Convert.ToInt32(enoughMoney);
            initialamountGold -= amountGold * crystalPrice;
            Console.WriteLine("Поздравляю! Вы приобрели: " + amountGold + " кристаллов");
            Console.WriteLine("У вас осталось: " + initialamountGold + " золота");
        }
    }
}
