using System;
using System.Collections.Generic;
using System.Threading;
namespace Simple_Atm
{
    class Program
    {
        static void Main(string[] args)
        {
            CardList cardlist = new CardList();
            User user1 = new User
            {
                Name = "Nebi",
                Surname = "Nebili",
                CreditCard = cardlist.card1
            };
            User user2 = new User
            {
                Name = "Kenan",
                Surname = "Idayatov",
                CreditCard = cardlist.card2
            };
            User user3 = new User
            {
                Name = "Kamal",
                Surname = "Eliyev",
                CreditCard = cardlist.card3
            };
            User user4 = new User
            {
                Name = "Tural",
                Surname = "Novruzov",
                CreditCard = cardlist.card4
            };
            User user5 = new User
            {
                Name = "Hormet",
                Surname = "Hemidov",
                CreditCard = cardlist.card5
            };
            User[] users = new User[5] { user1, user2, user3, user4, user5 };
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Enter Pin:");
                string pin = Console.ReadLine().ToString();
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var user in users)
                {
                    if (pin == user.CreditCard.Pin)
                    {
                        User myUser = user;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine($"Welcome------{user.Name} {user.Surname}------\n"); Console.ForegroundColor = ConsoleColor.White;
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[1]Balance\n[2]Withdraw cash\n[3]List of operations\n[4]Transfer cash");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Your option ");
                            int choose = int.Parse(Console.ReadLine());
                            if (choose == 1)
                            {
                                DateTime date1 = DateTime.Now;
                                string balanceMessage = "Look to balance " + date1.ToString();
                                OperationsList.AddOperations(balanceMessage);
                                Console.WriteLine($"Balance:{user.CreditCard.Balance}");
                                Console.Write("Press any key back menu");
                                Console.ReadKey(); Console.Clear();
                            }
                            else if (choose == 2)
                            {

                                Console.Clear();
                                while (true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"[1]10 Azn\n[2]20 Azn\n[3]50 Azn\n[4]100 Azn\n[5]Other amount\n[6]Back Menu");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Your option ");
                                    int choose1 = int.Parse(Console.ReadLine());
                                    if (choose1 == 1)
                                    {
                                        DateTime date2 = DateTime.Now;
                                        string removeBalance1 = "10 Azn  removed from your balance " + date2.ToString();
                                        OperationsList.AddOperations(removeBalance1);
                                        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("10 Azn  removed from your balance"); Console.ForegroundColor = ConsoleColor.White;
                                        user.CreditCard.Balance -= 10;
                                        Console.Write("Press any key back menu: "); Console.ReadKey(); Console.Clear();
                                        break;
                                    }
                                    else if (choose1 == 2)
                                    {
                                        DateTime date3 = DateTime.Now;
                                        string removeBalance2 = "20 Azn  removed from your balance " + date3.ToString();
                                        OperationsList.AddOperations(removeBalance2);
                                        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("20 Azn  removed from your balance"); Console.ForegroundColor = ConsoleColor.White;
                                        user.CreditCard.Balance -= 20;
                                        Console.Write("Press any key back menu: "); Console.ReadKey(); Console.Clear();
                                        break;
                                    }
                                    else if (choose1 == 3)
                                    {
                                        DateTime date4 = DateTime.Now;
                                        string removeBalance3 = "50 Azn  removed from your balance " + date4.ToString();
                                        OperationsList.AddOperations(removeBalance3);
                                        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("50 Azn  removed from your balance"); Console.ForegroundColor = ConsoleColor.White;
                                        user.CreditCard.Balance -= 50;
                                        Console.Write("Press any key back menu: "); Console.ReadKey(); Console.Clear();
                                        break;
                                    }
                                    else if (choose1 == 4)
                                    {
                                        DateTime date5 = DateTime.Now;
                                        string removeBalance4 = "100 Azn  removed from your balance " + date5.ToString();
                                        OperationsList.AddOperations(removeBalance4);
                                        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("100 Azn  removed from your balance"); Console.ForegroundColor = ConsoleColor.White;
                                        user.CreditCard.Balance -= 100;
                                        Console.Write("Press any key back menu: "); Console.ReadKey(); Console.Clear();
                                        break;
                                    }
                                    else if (choose1 == 5)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.Write("How much do you want to withdraw?->"); Console.ForegroundColor = ConsoleColor.White;
                                        double withdraw = double.Parse(Console.ReadLine());
                                        try
                                        {
                                            if (withdraw > user.CreditCard.Balance)
                                            {
                                                throw new LackOfBalanceException("This withdraw bigger than balance");
                                            }
                                        }
                                        catch (LackOfBalanceException lackOfBalanceException)
                                        {

                                            Console.WriteLine(lackOfBalanceException.Message);
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            continue;
                                        }
                                        if (withdraw <= user.CreditCard.Balance)
                                        {
                                            DateTime date6 = DateTime.Now;
                                            string removeBalance5 = $"{withdraw} Azn  removed from your balance " + date6.ToString();
                                            OperationsList.AddOperations(removeBalance5);
                                            user.CreditCard.Balance -= withdraw;
                                            Console.WriteLine($"{withdraw} Azn removed from your balance");
                                            Console.Write("Press any key back menu"); Console.ReadKey(); Console.Clear();
                                            break;
                                        }
                                    }
                                    else if (choose1 == 6)
                                    {
                                        DateTime date7 = DateTime.Now;
                                        string removeBalance6 = "{withdraw} Azn  removed from your balance " + date7.ToString();
                                        OperationsList.AddOperations(removeBalance6);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect option wait 1.5 second...");
                                        Thread.Sleep(1500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                continue;
                            }
                            else if (choose == 3)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                OperationsList.ShowOperations();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Press any key to continue: ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (choose == 4)
                            {
                                int check = 0;
                                Console.Clear();
                                while (true)
                                {
                                    Console.Write("Which card you want transfer(PIN)?->");
                                    string transferPin = Console.ReadLine().ToString();
                                    if (transferPin == pin)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("This your own card"); Console.ForegroundColor = ConsoleColor.White;
                                        Thread.Sleep(1500);
                                        Console.Clear();
                                        continue;
                                    }
                                    foreach (var userr in users)
                                    {

                                        if (transferPin == userr.CreditCard.Pin)
                                        {
                                            check++;
                                            Console.Write("Transfay pay amount: ");
                                            double transferPay = double.Parse(Console.ReadLine());
                                            userr.CreditCard.Balance += transferPay;
                                            foreach (var userrr in users)
                                            {
                                                if (userrr.CreditCard.Pin == pin)
                                                {
                                                    try
                                                    {
                                                        if (myUser.CreditCard.Balance - transferPay < 0)
                                                        {
                                                            throw new LackOfBalanceException($"There is no {transferPay} money on the balance "); ;
                                                        }
                                                    }
                                                    catch(LackOfBalanceException lackOfBalanceException)
                                                    {
                                                        Console.WriteLine(lackOfBalanceException.Message);
                                                        Thread.Sleep(1500);
                                                        Console.Clear();
                                                        break;
                                                    }
                                                    userrr.CreditCard.Balance -= transferPay;
                                                    Console.WriteLine($"{transferPay} Azn transfered");
                                                    DateTime date8 = DateTime.Now;
                                                    string trasnferMessage = $"{transferPay} tranferd to {transferPin} pin card " + date8.ToString();
                                                    OperationsList.AddOperations(trasnferMessage);
                                                    Thread.Sleep(1500);
                                                    Console.Clear();
                                                    break;
                                                }
                                            }
                                        }
                                        else continue;
                                        break;
                                    }
                                    if (check == 0)
                                    {
                                        Console.WriteLine("Incorrect Pin");
                                        continue;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                Console.WriteLine("Incorrect pin");
            }
        }
    }
}
