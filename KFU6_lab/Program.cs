using System;


namespace KFU6_lab
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.BankAccount\n");
            Bank account = new Bank(72658255, 345000, AccountType.Current);
            Console.WriteLine(account);
            Console.WriteLine("Press Enter");
            Console.ReadKey();

            Console.WriteLine("Task 2.Generated AccountNumber\n");
            GeneratedAccountNumber account1 = new GeneratedAccountNumber(250000, AccountType.Savings);
            Console.WriteLine(account1);
            Console.WriteLine("Press Enter");
            Console.ReadKey();

            Console.WriteLine("Task 3.Withdraw and Deposit\n");
            Console.WriteLine("Список возможных команд: |Внести| |Вывести| |Баланс| |Выход|");
            string command;
            do
            {
                Console.WriteLine("Введите команду");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "внести":
                        Console.WriteLine("Введите сумму, которую хотите внести\n");
                        bool dep = decimal.TryParse(Console.ReadLine(), out decimal dep_money);
                        if (!dep)
                        {
                            do
                            {
                                Console.WriteLine("Вы ввели не число, повторите попытку");
                                dep = decimal.TryParse(Console.ReadLine(), out dep_money);

                            }
                            while (!dep);

                        }
                        account.Deposit(dep_money);
                        break;
                    case "вывести":
                        Console.WriteLine("Введите сумму, которую хотите вывести");
                        bool with = decimal.TryParse(Console.ReadLine(), out decimal with_money);
                        if (!with)
                        {
                            do
                            {
                                Console.WriteLine("Вы ввели не число, повторите попытку");
                                dep = decimal.TryParse(Console.ReadLine(), out with_money);

                            }
                            while (!with);

                        }
                        account.WithDraw(with_money);
                        break;
                    case "баланс":
                        account.GetBalance();
                        break;
                    case "выход":
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверную команду\n");
                        break;
                }
            } while (!command.Equals("выход"));

            Console.WriteLine("Домашнее задание 7.1\n");
            Building building = new Building(20, 5, 30, 2);
            Console.WriteLine(building);
            Console.WriteLine("Количество квартир на этаже: " + building.GetApartmentsOnFloor());
            Console.WriteLine("Количество квартир в подъезде: " + building.GetApartmentsInEntrance());
            Console.WriteLine("Высота этажа: " + building.GetFloorHeight());
            Building building2 = new Building(30, 11, 165, 5);
            Console.WriteLine(building2);
            Console.WriteLine("Количество квартир на этаже: " + building2.GetApartmentsOnFloor());
            Console.WriteLine("Количество квартир в подъезде: " + building2.GetApartmentsInEntrance());
            Console.WriteLine("Высота этажа: " + building2.GetFloorHeight());
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();




        }
    }
}

