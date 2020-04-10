using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceProject.ViewModel
{
    public class UserAll
    {
        //User
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        // Bike
        public int MotorbikeId { get; set; }
        public string MotorbikeModeOfUse { get; set; }
        public string MotorbikeRegistration { get; set; }
        public double MotorbikeValue { get; set; }


        // Car
        public int CarId { get; set; }
        public string CarModeOfUse { get; set; }
        public string CarRegistration { get; set; }
        public double CarValue { get; set; }

        // Claim
        public int ClaimId { get; set; }
        public string Nature { get; set; }
        public string Location { get; set; }
        public System.DateTime Date { get; set; }
    }
}