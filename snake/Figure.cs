/*
 * Created by SharpDevelop.
 * User: salek
 * Date: 14.07.2016
 * Time: 4:04
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
	/// Description of Figure.
	/// </summary>
	class Figure
	{
		protected List<Point> pList;
		
		public void Drow() 
			{
				foreach (Point p in pList)
				{
					p.Draw();	
				}
			}
	}
}
