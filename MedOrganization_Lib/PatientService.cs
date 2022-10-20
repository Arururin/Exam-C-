using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MedOrganization_Lib
{
    public class PatientService
    {
        public void Print(Patient patient)
        {
            Console.WriteLine($"ID: {patient.patientId}");
            Console.WriteLine($"Имя: {patient.name}");
            Console.WriteLine($"Фамилия: {patient.surname}");
            Console.WriteLine($"Отчество: {patient.patronymic}");
            Console.WriteLine($"ИИН: {patient.IIN}");
        }
        public void PrintPatientsList(List<Patient> patients)
        {
            foreach (Patient p in patients)
            {
                Console.WriteLine($"ID: {p.patientId}");
                Console.WriteLine($"Имя: {p.name}");
                Console.WriteLine($"Фамилия: {p.surname}");
                Console.WriteLine($"Отчество: {p.patronymic}");
                Console.WriteLine($"ИИН: {p.IIN}");
            }
        }
        public void PrintPatientsListByFullName(List<Patient> patients, string fullName)
        {
            foreach (Patient p in patients)
            {
                if (p.FullName == fullName)
                {
                    Console.WriteLine($"ID: {p.patientId}");
                    Console.WriteLine($"Имя: {p.name}");
                    Console.WriteLine($"Фамилия: {p.surname}");
                    Console.WriteLine($"Отчество: {p.patronymic}");
                    Console.WriteLine($"ИИН: {p.IIN}");
                }
                else
                {
                    Console.WriteLine("Данного пациента не существует!");
                }
            }
        }

        public void PrintPatientsListByIIN(List<Patient> patients, string iin)
        {
            foreach (Patient p in patients)
            {
                if (p.FullName == iin)
                {
                    Console.WriteLine($"ID: {p.patientId}");
                    Console.WriteLine($"Имя: {p.name}");
                    Console.WriteLine($"Фамилия: {p.surname}");
                    Console.WriteLine($"Отчество: {p.patronymic}");
                    Console.WriteLine($"ИИН: {p.IIN}");
                }
                else
                {
                    Console.WriteLine("Данного пациента не существует!");
                }
            }
        }
    }
}
