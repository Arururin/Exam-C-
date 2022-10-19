using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Lib
{
    public enum Status { Approved, NotApproved }
    public class AttachmentRequest
    {
        public AttachmentRequest()
        {

        }
        public AttachmentRequest(DateTime DoC, Patient patient, Status status)
        {
            this.DoC = DoC;
            this.patient = patient;
            this.status = status;
        }

        public int attachmentRequestId { get; set; }
        public DateTime createDate { get; set; }
        public Patient patient { get; set; }
        public Status status { get; set; }

        //public void PatientAttachment()

        //public void CreateAttachmentRequest()

        //public void FindByFIO()

        //public void FindByIIN()


    }
}
