using System.Text.RegularExpressions; // using directives are copied as is
using System.Linq;
using System;

// ========================================================
// DO NOT EDIT. FILE GENERATED ON 2/11/2014 11:10:03 PM.
// ========================================================

namespace DTOGenerator.Sample
{
	public class UsingNamespaceDTO
	{
		private UsingNamespaceDTO() {}

		/// <param name="name">Person's first name </param>
		public UsingNamespaceDTO(int age, string name, Regex validationRule)
		{
			this.Age = age;
			this.Name = name;
			this.ValidationRule = validationRule;
		}

		public int Age { get; set; }

		/// <summary>
        /// Person's first name
        /// </summary>
		public string Name { get; set; }

		public Regex ValidationRule { get; set; }

	}
}
