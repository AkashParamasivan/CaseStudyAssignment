using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
	class EmployeePromotion
	{
		
		static void Main(string[] args)
		{
			int position;
			string[] Name = new string[5];
			var name = new List<string>(10);
			Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
			for (int i = 0; i < Name.Length; i++)
			{
				Name[i] = Console.ReadLine();
			}

			for (int i = 0; i < Name.Length; i++)
			{
				name.Add(Name[i]) ;
			}

			//-------To check Employee Position
			Console.WriteLine("Please enter the name of the employee to check promotion position");
			position = Convert.ToInt32(Console.ReadLine());
			int index = Array.IndexOf(Name,Name[position-1]);
			Console.WriteLine(" “{0}” is the position {1} for promotion.", Name[index], index+1);
			Console.WriteLine("-----------------------");


			//for (int i = 1; i < Name.Length+1; i++)
			//{
			//	if (i == position)
			//	{
			//		Console.WriteLine(" “{0}” is the position {1} for promotion.", Name[i-1],i);
			//		break;
			//	}
			//}
			//foreach (string N in name)
			//{
			//	Console.WriteLine(N);
			//}

		    //------To check the capacity of the list and reduce to required size------------
			Console.WriteLine("The current size of the collection is {0}", name.Capacity);
			name.TrimExcess();
			Console.WriteLine("The size after removing the extra space is {0}",name.Capacity);

			Console.WriteLine("-----------------");


			//------Sorting the employee list that user enters------------

			Console.WriteLine("Promoted employee list:");
			name.Sort();
			foreach (string N in name)
			{
				Console.WriteLine(N);
			}


			Console.ReadKey();


		}

	}

}

