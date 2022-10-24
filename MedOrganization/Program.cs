using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedOrganization.Library;

namespace MedOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            PatientService patientService = new PatientService();
            patientService.GeneratePatient(6);

            MedOrganizationService medOrganizationService = new MedOrganizationService();
            medOrganizationService.GenetateMed();

            AttachModul attachModul = new AttachModul();
            string message = "";

            while (true)
            {
                Console.WriteLine("Добро пожаловать в Медицинскую организацию!");
                Console.WriteLine("");
                Console.WriteLine("1. Отображения всех пациентов");
                Console.WriteLine("2. Отображение всех мед. центров");
                Console.WriteLine("3. Прикрепление пациента");
                Console.WriteLine("4. Отображение всех пациентов, прикрепленных к мед. организациям");
                Console.WriteLine("0. Выход");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            patientService.SearchPatient();
                        }
                        break;
                    case 2:
                        {
                            medOrganizationService.SearchMedOrg();
                        }
                        break;

                    case 3:
                        {
                            if (attachModul.AttachPatient(ref medOrganizationService, ref patientService, out message))
                            {
                                attachModul.AttachPatient(ref medOrganizationService, ref patientService, out message);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(message);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(message);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }
                        break;
                    case 4:
                        {
                            medOrganizationService.PrintAttachedPatients(ref patientService);
                        }
                        break;
                    case 0:
                        return;
                }
            }

        }
    }
}
