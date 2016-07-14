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
			//Console.SetBufferSize(80,25);
			
			//Border
					
			HorizontalLine upline = new HorizontalLine(0,78, 0, '+');
			HorizontalLine downline = new HorizontalLine(0,78, 24, '+');
			VerticalLine leftline = new VerticalLine(0,24,0,'+');
			VerticalLine rightLine = new VerticalLine(0,24,78,'+');	
			upline.Drow();
			downline.Drow();
			leftline.Drow();
			rightLine.Drow();
			
			//Point
			
			Point p = new Point(4,5,'@');
			p.Draw();

			
			Console.ReadLine();
		}
	}
}