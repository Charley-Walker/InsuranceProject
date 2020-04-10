using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceProject.ViewModel
{
    public class UserCarBike
    {
        //User
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


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
    }
}