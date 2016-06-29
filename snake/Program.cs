/*
 * Created by SharpDevelop.
 * User: salek
 * Date: 29.06.2016
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace snake
{
	class Program
	{
		public static void Main(string[] args)
		{				
			int x1 = 1;
			int y1 = 2;
			char sym1 = '*';
		
			Draw(x1,y1,sym1);
			
			Console.ReadLine();
		}
		
		static void Draw (int x, int y, char sym) {
			
			Console.SetCursorPosition(x, y);
			Console.Write(sym);		
			
			
		}
	}
}