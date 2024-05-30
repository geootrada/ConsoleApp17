using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExchangeRubToJena = "1";
            const string CommandExchangeRubToYuan = "2";
            const string CommandExchangeJenaToRub = "3";
            const string CommandExchangeJenaToYuan = "4";
            const string CommandExchangeYuanToRub = "5";
            const string CommandExchangeYuanToJena = "6";
            const string CommandExit = "7";
                        
            float rubWalletBalance;
            float jenaWalletBalance;
            float yuanWalletBallance;
            float rubToJena = 0.567f;
            float rubToYuan = 12.28f;
            float jenaToRub = 1.76f;
            float jenaToYuan = 21.62f;
            float yuanToRub = 0.081f;
            float yuanToJena = 0.046f;
            float amountCurrencyExchange;
            string userSelection;
            bool isProgress = true;

            Console.WriteLine("Добро пожаловать в Азиатский обменный терминал!\nУ нас вы можете выгодно обменять три главные азиатские валюты.");
            Console.Write("Введите баланс рублей: ");
            rubWalletBalance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс японских йен: ");
            jenaWalletBalance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс китайских юаней: ");
            yuanWalletBallance = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Предлагаем следующие операции:");
            Console.WriteLine($"{CommandExchangeRubToJena} - обмен рублей на японские йены");
            Console.WriteLine($"{CommandExchangeRubToYuan} - обмен рублей на китайские юани");
            Console.WriteLine($"{CommandExchangeJenaToRub} - обмен японских йен на рубли");
            Console.WriteLine($"{CommandExchangeJenaToYuan} - обмен японских йен на китайские юани");
            Console.WriteLine($"{CommandExchangeYuanToRub} - обмен китайских юаней на рубли");
            Console.WriteLine($"{CommandExchangeYuanToJena} - обмен китайских юаней на японские йены");
            Console.WriteLine($"{CommandExit} - выход из обменного терминала");
            Console.Write("Ваш выбор: ");
            

            while (isProgress)
            {
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case CommandExchangeRubToJena:
                        Console.WriteLine("Меняем рубли на японские йены");
                        Console.Write("Сколько желаете обменять ");
                        amountCurrencyExchange = Convert.ToSingle(Console.ReadLine());
                        if (amountCurrencyExchange <= rubWalletBalance)
                        {
                            rubWalletBalance -= amountCurrencyExchange;
                            jenaWalletBalance = jenaWalletBalance + amountCurrencyExchange / rubToJena;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточное количество рублей");
                        }
                        break;

                    case CommandExchangeRubToYuan:
                        Console.WriteLine("Меняем рубли на китайские юани");
                        Console.Write("Сколько желаете обменять ");
                        amountCurrencyExchange = Convert.ToSingle(Console.ReadLine());
                        if (amountCurrencyExchange <= rubWalletBalance)
                        {
                            rubWalletBalance -= amountCurrencyExchange;
                            yuanWalletBallance = yuanWalletBallance + amountCurrencyExchange / rubToYuan;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточное количество рублей");
                        }
                        break;

                    case CommandExchangeJenaToRub:
                        Console.WriteLine("Меняем японские йены на рубли");
                        Console.Write("Сколько желаете обменять ");
                        amountCurrencyExchange = Convert.ToSingle(Console.ReadLine());
                        if (amountCurrencyExchange <= jenaWalletBalance)
                        {
                            jenaWalletBalance -= amountCurrencyExchange;
                            rubWalletBalance = rubWalletBalance + amountCurrencyExchange / jenaToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточное количество японских йен");
                        }
                        break;

                    case CommandExchangeJenaToYuan:
                        Console.WriteLine("Меняем японские йены на китайские юани");
                        Console.Write("Сколько желаете обменять ");
                        amountCurrencyExchange = Convert.ToSingle(Console.ReadLine());
                        if (amountCurrencyExchange <= jenaWalletBalance)
                        {
                            jenaWalletBalance -= amountCurrencyExchange;
                            yuanWalletBallance = yuanWalletBallance + amountCurrencyExchange / jenaToYuan;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточное количество японских йен");
                        }
                        break;

                    case CommandExchangeYuanToRub:
                        Console.WriteLine("Меняем китайские юани на рубли");
                        Console.Write("Сколько желаете обменять ");
                        amountCurrencyExchange = Convert.ToSingle(Console.ReadLine());
                        if (amountCurrencyExchange <= jenaWalletBalance)
                        {
                            yuanWalletBallance -= amountCurrencyExchange;
                            rubWalletBalance = rubWalletBalance + amountCurrencyExchange / yuanToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточное количество китайских юаней");
                        }
                        break;

                    case CommandExchangeYuanToJena:
                        Console.WriteLine("Меняем китайские юани на японские йены");
                        Console.Write("Сколько желаете обменять ");
                        amountCurrencyExchange = Convert.ToSingle(Console.ReadLine());
                        if (amountCurrencyExchange <= yuanWalletBallance)
                        {
                            yuanWalletBallance -= amountCurrencyExchange;
                            jenaWalletBalance = jenaWalletBalance + amountCurrencyExchange / yuanToJena;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточное количество китайских юаней");
                        }
                        break;

                    case CommandExit:
                        {
                            isProgress = false;
                            Console.WriteLine("Обменный терминал закрывается");
                        }
                        break;

                    default:
                        Console.WriteLine("Недопустимая операция");
                        break;
                }

                Console.WriteLine($"Баланс ваших валют: {rubWalletBalance} рублей, {yuanWalletBallance} китайских юаней, {jenaWalletBalance} японских йен");

            }

            Console.ReadKey();       
        }
    }
}
