﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.DAL.Models
{
    public class Service
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageName {  get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt {  get; set; }

    }
}
