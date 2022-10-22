using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MedOrganization_Lib
{
    public class User
    {
        public Patient patient { get; set; }
    }
    public enum AccessRights { User, Admin }
    public class Patient
    {
        public int patientId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string IIN { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public AccessRights accessRights { get; set; }

        public Patient()
        {

        }
        public Patient(int patientId, string name, string surname, string patronymic, string IIN, string login, string password, AccessRights accessRights)
        {
            this.patientId = patientId;
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.IIN = IIN;
            this.login = login;
            this.password = password;
            this.accessRights = accessRights;

        }

        public string FullName
        {
            get
            {
                return $"{name} {patronymic} {surname}";
            }
        }
        public override string ToString()
        {
            return String.Format($"{patientId}\n{FullName}\n{IIN}\n{accessRights}\n");
        }
    }
}

/*
 
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
 */
