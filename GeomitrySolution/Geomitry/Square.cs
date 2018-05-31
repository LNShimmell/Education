using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Square
	{
	

		public double LengthOfSides { get; set; }

		public double GetArea()
		{
			return LengthOfSides*LengthOfSides;
		} 
		public double GetPerimeter()
		{
			return LengthOfSides *4;
		}
		public void Print()
		{
			Console.WriteLine("Square with Length: {0}in\nArea: {1}in^2\nPerimeter: {2}in\n---------------------------------------------------", LengthOfSides, GetArea(), GetPerimeter());
		}



	}
}
