using Land.PL.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.DAL.Models
{
    public class PolicemanDecision
    {
        public int PolicemanDecisionId {  get; set; }
        
        public int Violationid {  get; set; }
        public TrafficViolation TrafficViolation { get; set; }
        public int Policemanid {  get; set; }
        public Policeman Policeman { get; set; }
        public string DecisionNotes {  get; set; }
        public DateTime DecisionDate {  get; set; }

        public bool ReferredToCourt {  get; set; }

        public int? CourtDecisionId { get; set; }
        public CourtDecisions CourtDecision { get; set; }
    }
}
