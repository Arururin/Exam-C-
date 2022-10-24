using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Library
{
    public class MedOrganization
    {
        public int Id { get; set; }
        public string NameOrg { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public List<Patient> patients;

        public MedOrganization()
        {
            patients = new List<Patient>();
        }


        public void PrintInfo()
        {
            Console.WriteLine($"ID - {Id}");
            Console.WriteLine($"Название - {NameOrg}");
            Console.WriteLine($"Адрес - {Address}");
            Console.WriteLine($"Номер - {Tel}");
            Console.WriteLine();
        }
    }
}
