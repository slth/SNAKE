/*
 * Created by SharpDevelop.
 * User: salek
 * Date: 14.07.2016
 * Time: 3:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	/// <summary>
	/// Description of HorizontalLine.
	/// </summary>
	class HorizontalLine
	{
			List<Point> pList;
			
			
			public HorizontalLine(int xLeft, int xRight, int y, char sym)
			{
				pList = new List<Point>();
				for (int x = xLeft; x <= xRight; x++)
				{
					Point p = new Point(x, y, sym);
					pList.Add(p);
				}
			}
			
			public void Drow() 
			{
				foreach (Point p in pList)
				{
					p.Draw();	
				}
			}
		
	}
}
