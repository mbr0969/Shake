using System;
namespace Shake
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Point p1 = new Point ();
			Point p2 = new Point ();

			p1.x = 4;
			p1.y = 4;
			p1.sym = '*';
				
			p2.x = 7;
			p2.y = 8;
			p2.sym = '#';

			p1.Draw ();
			p2.Draw ();

			Console.WriteLine ();
		}

	}
}