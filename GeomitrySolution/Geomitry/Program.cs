using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomitry
{
	class Program
	{
		static void Main(string[] args)
		{
			Square square1 = new Square();
			square1.LengthOfSides = 1.5;
			square1.Print();
			
			Square sqr = new Square();
			sqr.LengthOfSides = 1.53;
			sqr.Print();
		


			Rectangle rct = new Rectangle();
			rct.Length = 2;
			rct.Width = 3;
			rct.Print();
			//Console.WriteLine("Area: {0}in^2 \n Perimeter:{1}in ", rct.GetArea(), rct.GetPerimeter());

			Circle crc = new Circle();
			crc.radius = 5;
			crc.print();

			Cylinder cil = new Cylinder();
			cil.radius = 12;
			cil.length = 6;
			cil.print();

			Sphere sph = new Sphere();
			sph.radius = 4;
			sph.Print();
			



		}
	}
}
