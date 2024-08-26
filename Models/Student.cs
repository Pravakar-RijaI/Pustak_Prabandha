using System.ComponentModel.DataAnnotations;

namespace Pustak_Prabandha.Models
{
	public class Student : Person
	{
		[Key]
		private int Student_Id { get; set; }

		private string Roll_No { get; set; }

		private string Faculty { get; set; }

		private string Program { get; set; }

		private int Semester { get; set; }

		private string Year { get; set; }
		
		


	}
}
