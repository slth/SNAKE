/*
 * Created by SharpDevelop.
 * User: salek
 * Date: 29.06.2016
 * Time: 23:54
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
	class Program
	{
		public static void Main(string[] args)
		{				
			Point p1 = new Point(1, 3, '*');
			p1.Draw();
			
			Point p2 = new Point(5, 3, '#');
			p2.Draw();
			
			HorizontalLine line = new HorizontalLine(5,10,8, '*');
			line.Drow();
			
			VerticalLine vline = new VerticalLine(5,10,3,'$');
			vline.Drow();		

			
			Console.ReadLine();
		}
	}
}