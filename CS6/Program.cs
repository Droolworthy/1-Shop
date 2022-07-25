//Легенда:
//Вы приходите в магазин и хотите купить за своё золото кристаллы. 
//В вашем кошельке есть какое-то количество золота, продавец спрашивает у вас, сколько кристаллов вы хотите купить? 
//После сделки у вас остаётся какое-то количество золота и появляется какое-то количество кристаллов.
//Формально:
//При старте программы пользователь вводит начальное количество золота. Потом ему предлагается купить какое-то количество кристаллов по цене N(задать в программе самому). 
//Пользователь вводит число и его золото конвертируется в кристаллы. Остаток золота и кристаллов выводится на экран.
//Проверять на то, что у игрока достаточно денег ненужно.
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
