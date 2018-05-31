using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Sphere
	{
		public double radius { get; set; }


		public double GetArea()
		{
			return 4 * Math.PI * radius * radius;
		}

		public double GetVolume()
		{
			return (4 / 3) * Math.PI * Math.Pow(radius, 3);
		}
		public void Print()
		{
			Console.WriteLine("Sphere with radius:{2}in\n Surface Area:{0}in^2\n Volume : {1}in^3\n---------------------------------------------------", String.Format("{0:n}", GetArea()), String.Format("{0:n}", GetVolume()),radius);
		}
	}
}

