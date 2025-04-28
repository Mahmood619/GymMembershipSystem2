using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipSystem2.Classes
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
        public DateTime LastServiced { get; set; }
        public string ServicedBy { get; set; }
    }
}
