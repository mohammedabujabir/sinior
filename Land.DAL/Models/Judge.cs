﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.DAL.Models
{
    public class Judge
    {
        public int JudgeId { get; set; }
        public string Name { get; set; }

        public string Email {  get; set; }

        public string Phone {  get; set; }

        public string Address {  get; set; }

        public string Password {  get; set; }
        public ICollection<CourtDecisions> CourtDecisions { get; set; }
    }
}