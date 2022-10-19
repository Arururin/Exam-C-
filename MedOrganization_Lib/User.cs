using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedOrganization;

namespace MedOrganization.Lib
{
    public enum AccessRights { User, Admin }
    public class User
    {
        public User()
        {

        }
        public User(string login, string password, AccessRights accessRights, MedOrganization medOrganization)
        {
            this.login = login;
            this.password = password;
            this.accessRights = accessRights;
            this.medOrganization = medOrganization;
        }
        public string login { get; set; }
        public string password { get; set; }
        public AccessRights accessRights { get;set; }
        public MedOrganization medOrganization { get; set; }

    }
}
