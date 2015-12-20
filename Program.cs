using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
using Shake;

namespace Shake
{
	class MainClass
	{
		public static void Main (string[] args)
		{ 
			HorizontalLine upline = new HorizontalLine (0,70,0,'+');
			HorizontalLine downLine = new HorizontalLine (0,70,20,'+');
			VertikalLine leftLine = new VertikalLine (0, 20, 0, '+');
			VertikalLine rightLine = new VertikalLine (0, 20,70,'+');
			upline.Drow ();
			downLine.Drow ();
			leftLine.Drow ();
			rightLine.Drow ();

			Point p = new Point (4,5,'*');
			Snake snake = new Snake (p, 7, Direction.RIGHT);
			snake.Drow ();

		while(true){			
		if(Console.KeyAvailable)
		{
				ConsoleKeyInfo key = Console.ReadKey ();	
			    snake.HandleKey (key.Key);
		}
			snake.Move ();
			Thread.Sleep (200);
	   }
	}
  }
}