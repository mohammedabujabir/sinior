using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.DAL.Models
{
    public class Policeman
    {
        public int PolicemanId {  get; set; }

        public string Name {  get; set; }

        public string Badge_Number {  get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password {  get; set; }

        public ICollection<PolicemanDecision> Decisions { get; set; }

    }
}
