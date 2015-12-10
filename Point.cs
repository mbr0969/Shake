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
			Console.Write ("Создание нового объекта!");
			Console.Write (" \n");
		}

		public void Draw()
		{
			Console.SetCursorPosition(x,y);
			Console.Write(sym);
		}
	}
}

