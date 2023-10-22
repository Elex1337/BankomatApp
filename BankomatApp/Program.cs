using BankomatApp;
using System;

namespace Bankomat
{
    class Program
    {
        static void Main()
        {
            // Предполагаемый пароль кредитной карты
            string correctPassword = "1234";
            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Введите пароль: ");
                string enteredPassword = Console.ReadLine();

                if (enteredPassword == correctPassword)
                {
                    Console.WriteLine("Вход выполнен успешно!");
                    Client client = new Client("Иванов Иван Иванович");
                    Account account = Bank.OpenAccount(client);

                    while (true)
                    {
                        DisplayMenu();
                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "a":
                                Console.WriteLine($"Баланс: {account.Balance}");
                                break;

                            case "b":
                                Console.Write("Введите сумму для пополнения: ");
                                decimal amount = decimal.Parse(Console.ReadLine());
                                account.Deposit(amount);
                                Console.WriteLine("Счет пополнен успешно.");
                                break;

                            case "c":
                                Console.Write("Введите сумму для снятия: ");
                                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                                if (account.Balance >= withdrawalAmount)
                                {
                                    account.Withdraw(withdrawalAmount);
                                    Console.WriteLine($"Сумма {withdrawalAmount} снята со счета.");
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточно средств на счете.");
                                }
                                break;

                            case "d":
                                Console.WriteLine("Выход.");
                                return;

                            default:
                                Console.WriteLine("Неверный выбор. Пожалуйста, повторите.");
                                break;
                        }
                    }
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неверный пароль. Осталось попыток: {attempts}");
                }
            }

            if (attempts == 0)
            {
                Console.WriteLine("Исчерпаны все попытки. Приложение завершает работу.");
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("a. Вывести баланс");
            Console.WriteLine("b. Пополнить счёт");
            Console.WriteLine("c. Снять деньги");
            Console.WriteLine("d. Выход");
            Console.Write("Выберите действие: ");
        }
    }
}