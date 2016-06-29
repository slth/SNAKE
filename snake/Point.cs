/*
 * Created by SharpDevelop.
 * User: salek
 * Date: 30.06.2016
 * Time: 0:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace snake
{
	class Point
	{
		public int x;
		public int y;
		public char sym;
		
		public Point(int _x, int _y, char _sym) {
			x = _x;
			y = _y;
			sym = _sym;
			
		}

		public void Draw() {
			Console.SetCursorPosition(x, y);
			Console.Write(sym);	
		}
	}
}
