using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MedOrganization_Lib
{
    public class Patient
    {
        public Patient()
        {

        }
        public Patient(int patientId, string name, string surname, string patronymic, string IIN)
        {
            this.patientId = patientId;
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.IIN = IIN;
        }

        public int patientId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string IIN { get; set; }

        public string FullName
        {
            get
            {
                return $"{name} {surname} {patronymic}";
            }
        }
    }
}
