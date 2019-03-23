using System;


namespace StringNamespace{
	class StringClass{
		public static void Main(){
			
			/* livello 1: n00b
			string one;
			one="Hi";
			string two= "my name";
			string emp= ""; //stringa vuota
			string emp2= String.Empty;
			string nullstring= null;
			Console.WriteLine(emp);
			Console.WriteLine(emp2);
			Console.WriteLine($"Did you know that 'emp' string is {emp.Lenght} characters long?");
			Console.WriteLine($"Did you know that 'nullstring' string is {nullstring.Lenght} characters long?"); //non compila: non puoi calc la lung di stringhe null
			*/

			/* funzioni su string:
			ToUpper() : rende la stringa tutta maiusc
			ToLower() : minusc
			TrimStart(), TrimEnd(), Trim() : toglie spazi all'inizio, alla fine, a entrambi
			Substring(n1,n2) : ricava la sottostringa dalla pos n1 inclusa alla pos n2 esclusa [n1,n2)
			*/

			/* replacing: ovvero, vari modi di sostituire una variabile con la stringa corrispondente.
			string nome= "Pippo";
			string greet1= $" Ciao {nome}!";
			string greet2= "Ciao" + nome + ", brutto coglione!";
			string greet3= String.Format("Ciao {0}", nome);
			string greetTemplate= "Ciao **NOME**!";
			string greet4= greetTemplate.Replace(**NOME**,nome);
			*/

			/* esercizio: costruire un greet con due variabili, una per il saluto, una per nome
			terza variabile opzionale: 
			loud => uppercase
			quiet => lowercase
			null || empty => nessuna modifica
			*/

			string saluto= "Howdy";
			string nome= "neighbour";
			// string greet0= saluto + nome + '!';
			string greet1= $"{saluto}, {nome}!";
			string terza= "loud";

			if(terza=="loud")
				Console.WriteLine(greet1.ToUpper());

			if (terza=="quiet")
				Console.WriteLine(greet1.ToLower());

		}//END MAIN()
	}
}
