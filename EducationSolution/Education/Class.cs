using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Class
	{
		public string Name { get; set; }
		public string Language { get; set; } //CSharp or Java
		public string Code { get; set; }  //comeback and change
		public int Capacity { get; set; } // number of available seats in class
		public List<Student> Students = new List<Student>();
		public Instructor Instructor { get; set; }


	}
}
