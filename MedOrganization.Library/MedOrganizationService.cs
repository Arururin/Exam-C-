using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Library
{
    public enum Organisation { BMClinic, TauSunkar, SayUrpak, Sunkar, Medicum, Rakhat, ZhuldyzMed }
    public enum Address { Гоголя, Сатпаева, София, Розыбакиева, Жандосова, Шаляпина, Достык }

    public class MedOrganizationService
    {
        private Random rnd = new Random();
        public List<MedOrganization> listMed;

        public MedOrganization this[int id]
        {
            get
            {
                foreach (MedOrganization item in listMed)
                {
                    if (item.Id == id)
                        return item;
                }
                return null;
            }
        }

        public MedOrganizationService()
        {
            listMed = new List<MedOrganization>();
        }

        public void GenetateMed()
        {
            for (int i = 1; i < 7; i++)
            {
                MedOrganization med = new MedOrganization();
                med.Id = i;
                med.NameOrg = ((Organisation)(rnd.Next(0, 6))).ToString();
                med.Address = ((Address)rnd.Next(0, 6)).ToString();
                med.Tel = (rnd.Next(300000, 999999)).ToString();
                listMed.Add(med);
            }
        }

        public void PrintMed()
        {
            foreach (MedOrganization item in listMed)
            {
                item.PrintInfo();
                Console.WriteLine("----------------------------------");
            }
        }

        public void PrintAttachedPatients(ref PatientService patientService)
        {
            foreach (MedOrganization item in listMed)
            {
                foreach (Patient item2 in patientService.patients)
                {
                    if (item2.ID == item.Id)
                    {

                        item2.PrintInfo();
                        Console.WriteLine("----------------------------------");
                    }
                }
            }
        }


        public MedOrganization SearchMedOrg()
        {
            Console.Clear();
            PrintMed();
            Console.WriteLine("Введите имя и номер мед. организации ");
            string MedName = Console.ReadLine();
            string tel = Console.ReadLine();

            bool t = false;
            foreach (MedOrganization item in listMed)
            {
                if (item.NameOrg.Contains(MedName) && item.Tel.Contains(tel))
                {
                    item.PrintInfo();
                    return item;
                    t = true;

                    break;
                }
            }
            if (!t) Console.WriteLine("Такой организации не существует!");
            return null;
        }
    }
}
