using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MwosPrinters.Core
{
    [Table("ServiceRequests")]
    public class ServiceRequest : Request
    {
        public string ProblemDescription { get; set; }

        public override Email CreateEmailMessage()
        {
            //throw new NotImplementedException();
            Email email = new Email();
            email.ToRecipients = (ICollection<Contact>) Printer.Branch.NashuaBranch.ServiceContacts;
            email.CCRecipients = (ICollection<Contact>) Printer.Branch.Users;
            email.Subject = "Technician required at "  + Printer.Branch.Name;
            email.Body = "Serial No. " + this.Printer.SerialNumber 
                            + "/n " 
                            + ProblemDescription
                            + "/n"
                            ;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Technician required at " + Printer.Branch.Name);
            sb.AppendLine("Serial No. " + Printer.SerialNumber);
            sb.AppendLine();
            sb.AppendLine(ProblemDescription);
            
            return email;
        }
    }
}