using System;

namespace Shake
{
	public class Point
	{

		public int x;
		public int y;
		public char sym;

		public Point ()
		{
		}

		public void Draw()
		{
			Console.SetCursorPosition(x,y);
			Console.Write(sym);
		}
	}
}

