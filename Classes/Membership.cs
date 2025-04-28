using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipSystem2.Classes
{
    public class Membership
    {
        public int MembershipID { get; set; }
        public string Type { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
