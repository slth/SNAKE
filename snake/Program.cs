﻿/*
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
	
			Point p1 = new Point(1, 3, '*');
			p1.Draw();
			
			Point p2 = new Point(4, 5, '#');
			p2.Draw();
			
			Console.ReadLine();
		}
	}
}