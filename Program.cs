﻿using System;
using System.Collections.Generic;
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

			Console.WriteLine (' ');

			List<int> numlist = new List<int>();

			numlist.Add (0);
			numlist.Add (1);
			numlist.Add (2);

			int x = numlist[0];
			int y = numlist[1];
			int z = numlist[2];

			foreach(int i in numlist) 
			{
				
				Console.WriteLine (i);
			}

			Console.WriteLine ();
		}

	}
}