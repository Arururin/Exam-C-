using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Lib
{
    public class MedOrganization
    {
        public MedOrganization()
        {

        }
        public MedOrganization(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }
        public List<Patient> patients { get; set; }
        public List<AttachmentRequest> ar { get; set; }
    }
}
