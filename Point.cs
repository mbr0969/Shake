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
			Console.Write ("  \n");
			Console.Write ("Создание нового объекта!");
			Console.Write ("  \n");
		}

		public Point(int _x,int _y,char _sym)
		{
			Console.Write ("  \n");
			Console.Write ("Создание нового объекта!");
			Console.Write ("  \n");

			x = _x;
			y = _y;
			sym = _sym;
		}
		public void Draw()
		{
			Console.SetCursorPosition(x,y);
			Console.Write(sym);
		}
	}
}

