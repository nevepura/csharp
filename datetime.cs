/* calcola quanti giorni sei vecchio
*/

using System;


namespace aNamespace{
	class aClass{
		public static void Main(){
			
			/*
			int year= birthday.Year; // anche Month,Day,Hour,Minute,Second
			Console.WriteLine(year);

			var adesso= DateTime.Now;
			var oggi= DateTime.Today;
			var ieri= DateTime.Today.AddDays(-1);
			var domani= DateTime.Today.AddDays(1);
			var dopodomani= DateTime.Today.AddDays(2);
			
			//INTERVALLO
			TimeSpan duration= dopodomani - DateTime.Today;
			*/

			var birthday= new DateTime(1993,8,25);
			var oggi= DateTime.Today;
			TimeSpan vita= oggi - birthday;
			int gdv= (int)vita.TotalDays; //cast
			Console.WriteLine($"Ho vissuto per {(int)(gdv/365.25)} anni e {(int)(gdv%365.25)} giorni.");
			Console.WriteLine($"In giorni, ne ho vissuti {vita.TotalDays}.");

			var fut= gdv + 10000;
			Console.WriteLine($"Tra 10000 giorni avro` {(int)(fut/365.25)} anni e {(int)(fut%365.25)} giorni.");


		}
	}
}
