using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Library
{
    public class AttachModul
    {
        public bool AttachPatient(ref MedOrganizationService organ, ref PatientService patientService, out string message)
        {
            Console.Clear();

            try
            {
                foreach (Patient p in patientService.patients)
                {
                    p.PrintInfo();
                }
                Console.WriteLine("");
                Patient selectPatient = new Patient();
                Console.WriteLine("Выберите пациента ");
                int choicePatient = Int32.Parse(Console.ReadLine());
                selectPatient = patientService[choicePatient];
                Console.WriteLine("");


                foreach (MedOrganization m in organ.listMed)
                {
                    m.PrintInfo();
                }
                Console.WriteLine("");
                MedOrganization selectMed = new MedOrganization();
                Console.WriteLine("Выберите мед. организацию ");
                int choiceMed = Int32.Parse(Console.ReadLine());
                selectMed = organ[choiceMed];
                Console.WriteLine("");

                Console.Clear();

                var t = organ.listMed.FirstOrDefault(f => f.Id == choiceMed);

                foreach (var p in t.patients)
                {
                    if (p.ID == choicePatient)
                    {
                        message = "Данный пациент уже пркреплен!";
                        return false;
                    }
                }

                t.patients.Add(selectPatient);

                foreach (var ps in patientService.patients)
                {
                    if (ps.ID == choiceMed)
                    {
                        {
                            ps.MedOrgan = selectMed;
                        }
                    }
                }

                message = "Пациент успешно прикреплен!";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Console.WriteLine(ex);
                return false;
            }
        }

    }

}

