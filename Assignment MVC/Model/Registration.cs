using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public class Registration
    {

        [Required(ErrorMessage = "Name is compulsary feild")]  
        public int? Name { get; set; }

        [Required(ErrorMessage = "Email name is compulsary")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone no is compulsary")]
        public double? Phone { get; set; }

        [Required(ErrorMessage = "Will Attend is compulsary")]
        //public bool WillAttend { get; set; }

        public WillAttend Options { get; set; }
       
    }
    public enum WillAttend
    {
        Yes,
        No
    }
}
