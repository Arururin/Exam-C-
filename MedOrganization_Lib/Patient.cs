using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Lib
{
    public class Patient
    {
        public Patient()
        {

        }
        public Patient(string Name, string Surname, string Patronymic, string IIN)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.IIN = IIN;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string IIN { get; set; }


        public void Print()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Отчество: {Patronymic}");
            Console.WriteLine($"ИИН: {IIN}");
        }
    }
}
