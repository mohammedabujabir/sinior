using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.DAL.Models
{
    public class Citizen
    {
        public int CitizenId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Password { get; set; }

        public string Camera_id { get; set; }
      
        public ICollection<Car> Cars { get; set; }

        public ICollection<TrafficViolation> TrafficViolations { get; set; }
    }
}