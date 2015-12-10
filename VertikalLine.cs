using System;
using System.Collections.Generic;

namespace Shake
{
	public class VertikalLine
	{
		List<Point> vList;
				
		public VertikalLine (int x, int yUp,int yDown,char sym)
		{
			vList = new List<Point>();
			for(int y = yUp; y <= yDown; y++)
			{
				Point v = new Point(x, y,sym);
				vList.Add(v);
			}
		}

		public void Draw()
		{
			foreach (Point v in vList) {
				v.Draw ();
			}
		}
	}
}

