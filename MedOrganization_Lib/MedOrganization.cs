using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization_Lib
{
    public class MedOrganization
    {
        public MedOrganization()
        {

        }
        public MedOrganization(int medOrganizationId, string name, List<Patient> patients, List<AttachmentRequest> attachmentRequests)
        {
            this.medOrganizationId = medOrganizationId;
            this.name = name;
            this.patients = patients;
            this.attachmentRequests = attachmentRequests;
        }

        public int medOrganizationId { get; set; }
        public string name { get; set; }
        public List<Patient> patients { get; set; }
        public List<AttachmentRequest> attachmentRequests { get; set; }
    }
}
