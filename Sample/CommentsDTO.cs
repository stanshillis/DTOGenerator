using System;

// ========================================================
// DO NOT EDIT. FILE GENERATED ON 2/11/2014 11:09:57 PM.
// ========================================================

namespace DTOGenerator.Sample
{
	/// <summary>
    /// Class level comment
    /// </summary>
	public class CommentsDTO
	{
		private CommentsDTO() {}

		/// <param name="age">Comment for the age property </param>
		/// <param name="name">Comment for the name property Additional comment for the name property </param>
		public CommentsDTO(int age, string name, DateTime changeTimestamp)
		{
			this.Age = age;
			this.Name = name;
			this.ChangeTimestamp = changeTimestamp;
		}

		/// <summary>
        /// Comment for the age property
        /// </summary>
		public int Age { get; set; }

		/// <summary>
        /// Comment for the name property
        /// Additional comment for the name property
        /// </summary>
		public string Name { get; set; }

		public DateTime ChangeTimestamp { get; set; }

	}
}
