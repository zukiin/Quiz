﻿using Abantwana_DayCare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abantwana_DayCare.ViewModels
{
	public class ParentCreateVM
	{
		
			
			[Required]
			[Display(Name = "First Name")]
			[RegularExpression(pattern: @"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Numbers and special characters are not allowed.")]
			[StringLength(maximumLength: 35, ErrorMessage = "Fist Name must be atleast 3 characters long", MinimumLength = 3)]
			public string FirstName { get; set; }

			[Required]
			[Display(Name = "Last Name")]
			[RegularExpression(pattern: @"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Numbers and special characters are not allowed.")]
			[StringLength(maximumLength: 35, ErrorMessage = "Fist Name must be atleast 3 characters long", MinimumLength = 3)]
			public string LastName { get; set; }

			[Required]
			[Display(Name = "Email")]
			[DataType(dataType: DataType.EmailAddress)]
			public string Email { get; set; }

			[Required]
			[Display(Name = "Phone Number")]
			[DataType(dataType: DataType.PhoneNumber)]
			[RegularExpression(pattern: @"^\(?([0]{1})\)?[-. ]?([1-9]{1})[-. ]?([0-9]{8})$", ErrorMessage = "Entered phone format is not valid.")]
			[StringLength(maximumLength: 10, ErrorMessage = "SA Contact Number must be exactly 10 digits long", MinimumLength = 10)]
			public string phone { get; set; }

			[Required]
			[Display(Name = "ID Number")]
			[StringLength(maximumLength: 13, ErrorMessage = "SA ID Number must be exactly 13 digits long", MinimumLength = 13)]
			public string ID_Number { get; set; }

			[Required]
			[MinLength(3)]
			[MaxLength(150)]
			[Display(Name = "Physical Address")]
			public string address { get; set; }

			[Required]
			[Display(Name = "Date of birth")]
			[DataType(dataType: DataType.Date)]

			public string DOB { get; set; }

			[Required]
			[Display(Name = "Work Place")]
			[RegularExpression(pattern: @"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Numbers and special characters are not allowed.")]
			[StringLength(maximumLength: 35, ErrorMessage = "Company name must be atleast 3 characters long", MinimumLength = 3)]
			public string Work_Place { get; set; }

			[Required]
			[Display(Name = "Work place telephone")]
			[DataType(dataType: DataType.PhoneNumber)]
			[RegularExpression(pattern: @"^\(?([0]{1})\)?[-. ]?([1-9]{1})[-. ]?([0-9]{8})$", ErrorMessage = "Entered phone format is not valid.")]
			[StringLength(maximumLength: 10, ErrorMessage = "SA Contact Number must be exactly 10 digits long", MinimumLength = 10)]
			public string CompanyPhone { get; set; }

			[Display(Name = "Relationship")]
			public relationship relationship { get; set; }



			[Required]
			[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
			[DataType(DataType.Password)]
			[Display(Name = "Password")]
			public string Password { get; set; }

			[DataType(DataType.Password)]
			[Display(Name = "Confirm password")]
			[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
			public string ConfirmPassword { get; set; }


		public int generateID()
		{
			ApplicationDbContext db = new ApplicationDbContext();

			var x = db.Parent_Model.Count();

			return x + 1;
		}

	}
}