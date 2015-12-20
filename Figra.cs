using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
	public class Figra
	{
		public Figra ()
		{
		}
		protected	 List<Point> pList;
		public void Drow(){
			foreach (Point p in pList) {
				p.Draw ();
			}
		}


	}
}

