using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedOrganization_Lib;

namespace MedOrganization.App
{
    internal class Program
    {

        //static string Path = @"C:\Temp\MyData.db";
        //static void Main(string[] args)
        //{
        //    int ch = 0;
        //    try
        //    {
        //        Console.ForegroundColor = ConsoleColor.White;
        //        UserService userService = new UserService(Path);
        //        string message = "";


        //        Console.WriteLine("Добро пожаловать в мобильное приложение MedOrganization!");
        //        Console.WriteLine("");
        //        Console.WriteLine("1. Авторизация");
        //        Console.WriteLine("2. Регистрация");
        //        Console.WriteLine("3. Выход");
        //        Console.Write("Выберете пункты меню: ");
        //        ch = Convert.ToInt32(Console.ReadLine());

        //        switch (ch)
        //        {
        //            case 1:
        //                {
        //                    string IIN;
        //                    string Password;
        //                    Console.Clear();
        //                    Console.Write("Введите ИИН: ");
        //                    IIN = Console.ReadLine();
        //                    Console.Write("Введите пароль: ");

        //                    Password = Console.ReadLine();
        //                    //personal_data user = userService.GetUser(IIN, Password);
        //                    //if (user == null)
        //                    //{
        //                    //    Console.WriteLine("ИИН и пароль введены не правильно!");
        //                    //}
        //                    //else
        //                    //{
        //                    //}



        //                    break;
        //                }
        //            case 2:
        //                {
        //                    break;
        //                }
        //            case 3:
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    catch (Exception) when (ch == 0)
        //    {
        //        Console.WriteLine("у не должен быть рвен 0");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        static string Path = @"C:\Temp\MyData.db";

        static void Main(string[] args)
        {
            int ch = 0;
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                UserService userService = new UserService(Path);
                string message = "";


                Console.WriteLine("Добро пожаловать в мобильное приложение MedOrganization!\n");
                Console.WriteLine("1. Авторизация");
                Console.WriteLine("2. Регистрация");
                Console.WriteLine("3. Выход");
                Console.Write("Выберете пункты меню: ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            string IIN;
                            string Password;
                            Console.Clear();
                            Console.Write("Введите ИИН: ");
                            IIN = Console.ReadLine();
                            Console.Write("Введите пароль: ");

                            Password = Console.ReadLine();
                            Patient user = userService.GetUser(IIN, Password);
                            if (user == null)
                            {
                                Console.WriteLine("ИИН и пароль введены не правильно!");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Добро пожаловать {0}", user.FullName);

                                Console.WriteLine("");
                                Console.WriteLine("1. Создать счет");
                                Console.WriteLine("2. Пополнить счет");
                                Console.WriteLine("3. Перевести деньги со счета");

                                //Console.Write("Выберете пункты меню: ");
                                //ch = Convert.ToInt32(Console.ReadLine());

                                //AccountService accountService = new AccountService(Path);


                                //switch (ch)
                                //{
                                //    case 1:
                                //        {
                                //            accountService.RegisterNotificationHandler(Lib.Notification.ResultCreateAccount);
                                //            accountService.CreateAccount(user.UserId);
                                //            break;
                                //        }

                                //    case 2:
                                //        {
                                //            List<Account> accounts = accountService.GetUserAccounts(user.UserId);
                                //            if (accounts.Count > 0)
                                //            {
                                //                foreach (Account item in accounts)
                                //                {
                                //                    //Console.WriteLine("{0}. {1} - {2} {3}",
                                //                    //    item.AccountId,
                                //                    //    item.IBAN,
                                //                    //    item.Balance,
                                //                    //    item.GetCurrencyName);

                                //                    Console.WriteLine(item.ToString());
                                //                }

                                //                Console.Write("Какой счет пополнить: ");
                                //                int temp = Convert.ToInt32(Console.ReadLine());

                                //                Console.Write("На какую сумму пополнить счет: ");
                                //                double balance = Convert.ToDouble(Console.ReadLine());

                                //                if (accountService.AddBalance(temp, balance))
                                //                {
                                //                    Console.WriteLine("Баланс пополнен");
                                //                }
                                //                else
                                //                {
                                //                    Console.WriteLine("Что-то пошло не так");
                                //                }


                                //            }
                                //            break;
                                //        }
                                //    case 3:
                                //        {

                                //            break;
                                //        }
                                //}


                            }
                            break;
                        }
                    case 2:
                        {
                            #region Registartion
                            Console.Write("Введите Ваш ИИН ");
                            string id = Console.ReadLine();

                            Console.Write("Введите Ваш ИИН ");
                            string name = Console.ReadLine();

                            Console.Write("Введите Ваш ИИН ");
                            string surname = Console.ReadLine();

                            Console.Write("Введите Ваш ИИН ");
                            string patronymic = Console.ReadLine();

                            Console.Write("Введите Ваш ИИН ");
                            string iin = Console.ReadLine();

                            Console.Write("Введите Ваш ИИН ");
                            string login = Console.ReadLine();

                            Console.Write("Введите Ваш ИИН ");
                            string password = Console.ReadLine();

                            Console.Write("Введите Ваш ИИН ");
                            string accessRights = Console.ReadLine();

                            //userService.CreateUser(new Patient())
                            #endregion
                        }
                        break;
                    default:
                        throw new Exception("Необходимо выбрать пункт меню");
                }
            }
            catch (Exception) when (ch == 0)
            {
                Console.WriteLine("у не должен быть рвен 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
