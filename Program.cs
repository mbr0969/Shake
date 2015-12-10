using System;
using System.Collections.Generic;
namespace Shake
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			Console.WriteLine (' ');

			HorizontalLine line = new HorizontalLine (1,15,5,'*');
			line.Draw ();
			VertikalLine vert = new VertikalLine (7, 3, 10, '*');
			vert.Draw ();

			Console.WriteLine ();
		}

	}
}