using System;
namespace Shake
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Point p1 = new Point (4,4,'*');

			//p1.x = 4;
			//p1.y = 4;
			//p1.sym = '*';
			p1.Draw ();

			Point p2 = new Point ();

			p2.x = 7;
			p2.y = 8;
			p2.sym = '#';
			p2.Draw ();

			Console.WriteLine ();
		}

	}
}