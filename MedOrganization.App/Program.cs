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
        static void Main(string[] args)
        {
            int ch = 0;
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                UserService userService = new UserService(); //Path
                string message = "";


                Console.WriteLine("Добро пожаловать в мобильное приложение MedOrganization!");
                Console.WriteLine("");
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
                            //personal_data user = userService.GetUser(IIN, Password);
                            //if (user == null)
                            //{
                            //    Console.WriteLine("ИИН и пароль введены не правильно!");
                            //}
                            //else
                            //{
                            //}



                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        break;
                    default:
                        break;
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
        }
    }
}
