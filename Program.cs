using System;
namespace Shake
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Point p1 = new Point (4,4,'*');
			p1.Draw ();

			Point p2 = new Point (8,7,'#');
			p2.Draw ();

			Console.WriteLine ();
		}

	}
}