
## DTO.tt creates DTO type classes out of simple T4 templates

Reduce amount of boilerplate code you need to write when working with DTO classes.
Let Visual Studio's T4 templating engine do the work for you.

## Feature Overview

* Name of the class is derived from T4 template's file name
* Namespace is derived from T4 template location inside the project using Visual Studio's standard convention
* DTO generator will carry over comments and "using" statements from T4 template file into the class
* Properties are defined by their *type* and *name* typed on one line, separated by a space

## Sample 1: Basic

**Template File:** BasicDTO.tt

**Contents:**

	int Age

	string Name

	<#@ include file="$(ProjectDir)DTO.tt" #>

**Generated File:** BasicDTO.cs

**Contents:**

	using System;

	// ========================================================
	// DO NOT EDIT. FILE GENERATED ON 2/11/2014 11:10:03 PM.
	// ========================================================

	namespace DTOGenerator.Sample
	{
		public class BasicDTO
		{
			private BasicDTO() {}

			public BasicDTO(int age, string name)
			{
				this.Age = age;
				this.Name = name;
			}

			public int Age { get; set; }

			public string Name { get; set; }

		}
	}

## Sample 2: Comments & "using" Statements

**Template File:** UsingNamespaceDTO.tt

**Contents:**

	using System.Text.RegularExpressions; // using directives are copied as is
	using System.Linq;

	int Age
	// Person's first name
	string Name
	public Regex ValidationRule { get; set; }

	<#@ include file="$(ProjectDir)DTO.tt" #>

**Generated File:** UsingNamespaceDTO.cs

**Contents:**

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
