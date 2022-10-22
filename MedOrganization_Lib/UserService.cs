using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Newtonsoft.Json;
using RestSharp;

namespace MedOrganization_Lib
{
    public class UserService
    {
        public string Path { get; set; }

        public UserService(string Path)
        {
            this.Path = Path;
        }
        public List<Patient> Users { get; set; }

        public bool CreateUser(Patient patient, out string message)
        {
            try
            {
                if (GetUser(patient.IIN) != null)
                {
                    message = "Пользователь с ИИН: " + patient.IIN + " уже зарегистрирован!";
                    return false;
                }
                else
                {
                    using (var db = new LiteDatabase(Path))
                    {
                        var users = db.GetCollection<Patient>("Users");

                        users.Insert(patient);

                        message = "Регистрация прошла успешно!";
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public Patient GetUser(string iin, string psw = null)
        {
            Patient patient = null;
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var users = db.GetCollection<Patient>("Users");
                    patient = users.FindOne(f => f.IIN == iin);
                    if (!string.IsNullOrWhiteSpace(psw))
                    {
                        patient = users.FindOne(f => f.IIN == iin && f.password == psw);
                    }
                }
            }
            catch
            {
                patient = null;
            }

            return patient;
        }

      
    }
}
