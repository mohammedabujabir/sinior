﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.DAL.Models
{
    public  class Car
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Color {  get; set; }

        public int CitizenId { get; set; }
        public Citizen Citizen { get; set; }
    }
}
