using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Model
{
    public class EmployeePostModel
    {
        [Required]
        [DefaultValue("")]
        [RegularExpression("^[A-Z][A-Za-z]{3,20}$", ErrorMessage = "Please Enter For Firstname At least 3 Characters and First letter Capital")]
        public string FirstName { get; set; }

        [Required]
        [DefaultValue("")]
        [RegularExpression("^[A-Z][A-Za-z]{3,20}$", ErrorMessage = "Please Enter For Lastname At least 3 Characters and First letter Capital")]
        public string LastName { get; set; }

        [DefaultValue("")]
        public string Address { get; set; }

        [Required]
        [DefaultValue(91)]
        [RegularExpression("^[1 - 9]{2}[6-9]{1}[0-9]{9}$", ErrorMessage = "Please Enter Valid Mobile No  Eg.919511949586")]
        public string Mobile { get; set; }
    }
}
