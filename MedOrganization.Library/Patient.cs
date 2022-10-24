using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Library
{
    public class Patient
    {
        public MedOrganization MedOrgan { get; set; }
        private string Name_;
        public string Name
        {
            get
            {
                return Name_;
            }
            set
            {
                Name_ = value;
            }
        }
        private string LastName_;
        public string LastName
        {
            get
            {
                return LastName_;
            }
            set
            {
                LastName_ = value;
            }
        }
        public int ID { get; set; }

        public string FullName
        {
            get
            {
                return $"{Name} {LastName}";
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Полное имя - {FullName}");
            Console.WriteLine("ID - " + ID);
            Console.WriteLine();
        }
    }
}
