using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Cylinder
	{
		public double length { get; set; }
		
		public double radius { get; set; }

		public double GetVolume()
		{
			return length * Math.Pow(radius, 2) * Math.PI;
		}
		public double GetArea()
		{
			return 2*(radius * radius * Math.PI) + (2*Math.PI * radius * length);
		}

		public void print()
		{
			Console.WriteLine("Cylinder with height:{2}in Radius:{3}in\nSurface Area: {0}in^2\nVolume : {1}in^3\n---------------------------------------------------", String.Format("{0:n}", GetArea()), String.Format("{0:n}", GetVolume()),length,radius);
		}
	}
}
