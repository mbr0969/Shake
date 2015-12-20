using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
	public class VertikalLine : Figra
	{

				
		public VertikalLine (int yUp,int yDown, int x, char sym)
		{
			pList = new List<Point>();
			for(int y = yUp; y <= yDown; y++)
			{
				Point v = new Point(x, y,sym);
				pList.Add(v);
			}
		}


	}
}

