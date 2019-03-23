//number guess

using System;


namespace newNamespace{
	class newClass{
		public static void Main(){
			int sol= new Random().Next(1,50);
			int cur= 0;

			while(cur!=sol && cur!=-1){
				Console.WriteLine("Scrivi un numero (-1 per uscire): ");
				cur= int.Parse(Console.ReadLine());

				if(cur==-1)
					Console.WriteLine("Ciao ciao!");
				else{
					if(cur>sol)
						Console.WriteLine($"{cur} e` troppo grande");
					else 
					{
						if(cur<sol) //!= -1
							Console.WriteLine($"{cur} e` troppo piccolo");
						else
						{
							if(cur==sol)
								Console.WriteLine("Corretto.");

						}
					}
				}

			} // END WHILE


		}
	}
}
