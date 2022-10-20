using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization_Lib
{
    public enum Status { Approved, NotApproved }
    public class AttachmentRequest
    {
        public AttachmentRequest()
        {

        }
        public AttachmentRequest(DateTime createDate, Patient patient, Status status)
        {
            this.createDate = createDate;
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
