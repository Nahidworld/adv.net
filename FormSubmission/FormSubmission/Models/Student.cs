using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
	public class Student
	{
        [Range(1,100, ErrorMessage = "Please Provide a Valid Id")]
		public int Id { get; set;  }
        //[Required(ErrorMessage = "Please Provide the Name")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Pleaze Provide the Email")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public DateTime Dob { get; set; }
        public string[] Hobbies { get; set; }

    }
}