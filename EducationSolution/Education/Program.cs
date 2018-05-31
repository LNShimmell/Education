using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Program
	{
		static void Main(string[] args)
		{
			Instructor DanTheMan = new Instructor(); 
			DanTheMan.Name = "Dan Levie";
			DanTheMan.Email = "Dan@gmail.com";
			DanTheMan.Experience = 17;
			DanTheMan.Phone = "123-343-4444";
			DanTheMan.Language = "CSHARP";

			Class DotNet4 = new Class();
			DotNet4.Capacity = 16;
			DotNet4.Instructor = DanTheMan;
			DotNet4.Language = "CSHARP";
			DotNet4.Name = "DotNET4";
		

			Student foster = new Student();
			foster.Absences = 0; 
			foster.ContactInfo = " contact information.......";
			foster.FirstJob = DateTime.MinValue;
			foster.Class = DotNet4;
			foster.Name = "Foster";

			Student JJ = new Student();
			JJ.Absences = 0;
			JJ.ContactInfo = "bsfbalfs";
			JJ.FirstJob = DateTime.MinValue;
			JJ.Class = DotNet4;
			JJ.Name = "John";



			Student Mitch = new Student() {
				Absences = 0,
				ContactInfo = "string",
				FirstJob = DateTime.MinValue,
				Class = DotNet4,
				Name = "Mitch"
				
			};

			DotNet4.Students.Add(foster);
			DotNet4.Students.Add(JJ);
			DotNet4.Students.Add(Mitch);
		}
	}
}
