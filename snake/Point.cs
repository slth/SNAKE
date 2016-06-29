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

		public void Draw() {
			Console.SetCursorPosition(x, y);
			Console.Write(sym);	
		}
	}
}
