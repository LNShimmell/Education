using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Circle
	{

		public double radius { get; set; }

		public double getArea (){
			return Math.Pow(radius,2) * Math.PI;
		}
		public double getPerimeter()
		{
			return 2 * radius * Math.PI;
		}
		public void print()
		{
			Console.WriteLine($"Circle with Radius: {radius}in\n Perimeter: {getPerimeter()}\nArea: {getArea()}in^2\n---------------------------------------------------");
		}
	}
}
