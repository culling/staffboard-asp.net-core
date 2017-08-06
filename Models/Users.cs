using System;
using System.ComponentModel.DataAnnotations;

namespace MvcStaffboard.Models
{



    public class User
    {
        public int ID {get; set;}


        //public string Status     { get; set; }
        public virtual Status Status {get; set;}


        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name="Last Name")]
        public string LastName  { get; set; }



        public string Username  { get; set; }


        public string Email     { get; set; }

    }


}