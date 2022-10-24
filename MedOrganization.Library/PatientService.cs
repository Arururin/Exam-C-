using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Library
{
    public enum name { Томирис, Алмас, Саяра, Сергей, Анастасия, Евгений }
    public enum lastName { И, А, С, Т, Р, Д }
    public class PatientService
    {

        private Random rnd = new Random();
        public List<Patient> patients;

        public Patient this[int iin]
        {
            get
            {
                foreach (Patient item in patients)
                {
                    if (item.ID == iin)
                        return item;
                }
                return null;
            }
        }

        public PatientService()
        {
            patients = new List<Patient>();
        }

        public void GeneratePatient(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Patient patient = new Patient();
                patient.Name = ((name)rnd.Next(1, 6)).ToString();
                patient.LastName = ((lastName)rnd.Next(1, 6)).ToString();
                patient.ID = i + 1;
                patients.Add(patient);
            }
        }

        public void PrintPatient()
        {
            foreach (Patient item in patients)
            {
                item.PrintInfo();
                Console.WriteLine("----------------------------------");
            }

        }

        public Patient SearchPatient()
        {
            bool res = false;
            Console.Clear();
            PrintPatient();
            Console.WriteLine("Введите имя пациента ");
            string fullName = Console.ReadLine();
            Console.WriteLine();

            foreach (Patient p in patients)
            {
                if (p.FullName == fullName)
                {
                    res = true;
                    Console.WriteLine("Найденный пациент:");
                    p.PrintInfo();
                    return p;
                }
            }
            if (!res)
            {
                Console.WriteLine("Такого пациента не существует!");
            }
            return null;
        }

    }
}
