using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intro_to_ASP.Models
{
    public class User
    {
		[Required]
		[StringLength(3)]
        public string Name { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public int Age { get; set; }
		[Required]
		public string Email { get; set; }

    }
}