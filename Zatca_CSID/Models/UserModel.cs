using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatca_CSID.Models
{
    public class UserModel
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string MobNo { get; set; }
        public string UserName { get; set; }
        public string userpassword { get; set; }
        public string c_userpassword { get; set; }
        public DateTime CreatedDt { get; set; }
        public int IsVerify { get; set; }
        public int IsActive { get; set; }
        public int LicenceDays { get; set; }
        public DateTime JwtToken_Issue { get; set; }
        public DateTime JwtToken_Expiry { get; set; }
        public string JwtUUID { get; set; }
        public string JwtToken { get; set; }
    }
}
