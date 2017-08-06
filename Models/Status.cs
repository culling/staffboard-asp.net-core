using System;
using System.ComponentModel.DataAnnotations;

namespace MvcStaffboard.Models
{
    public class Status
    {
        public int ID       { get; set; }

        public string Name  { get; set; }

        public string IconClassString { get; set; }
 
    }
}