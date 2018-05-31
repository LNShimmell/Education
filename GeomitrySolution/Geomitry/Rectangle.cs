using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Rectangle
	{
		public double Length { get; set; }

		public double Width { get; set; }

		public double GetArea()
		{
			return Length * Width;
		}

		public double GetPerimeter()
		{
			return Length * 2 + Width * 2;
		}
		public void Print()
		{
			Console.WriteLine($"Rectangle with length:{Length} width:{Width}in \nArea:{GetArea()}in^2\nPerimeter:{GetPerimeter()}in\n---------------------------------------------------");
		}
	}
}
