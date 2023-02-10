﻿using System.ComponentModel.DataAnnotations;

namespace RazorPageTask.Model
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
