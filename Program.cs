using System;
namespace Shake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x1 = 1;
			int y1 = 3;
			char sym1 = '*';

			int x2 = 4;
			int y2 = 6;
			char sym2 = '#';


			Draw (x1, y1, sym1);
			Draw (x2, y2,sym2);

			Console.WriteLine ();
		}

		static void Draw(int x, int y, char sym )
		{
			Console.SetCursorPosition(x,y);
			Console.Write(sym);
		}
	}
}