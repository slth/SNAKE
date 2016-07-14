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
			
			List<int> numList = new List<int>();
			numList.Add(0);
			numList.Add(1);
			numList.Add(2);
			
			int x = numList[0];			
			int y = numList[1];			
			int z = numList[2];
			
			foreach(int i in numList)
			{
				Console.WriteLine(i);
			}	
			
			numList.RemoveAt(0);
			
			List<Point> pList = new List<Point>();
			pList.Add(p1);
			pList.Add(p2);
			
			//list for hash and stars (symbols)
			List<char> charList = new List<char>();
			charList.Add('*');
			charList.Add('#');
			charList.Add('$');
			charList.Add('@');			
			charList.Add('&');
			
			//four point's
			//add cordinates
			//add to list
			Point p3 = new Point(5,5,'@');
			Point p4 = new Point(6,5,'@');			
			Point p5 = new Point(7,5,'@');
			Point p6 = new Point(8,5,'@');
			
			List<Point> pList2 = new List<Point>();
			pList2.Add(p3);
			pList2.Add(p4);
			pList2.Add(p5);
			pList2.Add(p6);	
			
			Console.ReadLine();
		}
	}
}