using System;
using System.Collections.Generic;

class Class
{ 
	static void Main() 
	{	//array of possible numbers
		int[] Array = new int[] { 10,0,11,4,6,5,19,1,3 }; 
		//a number that should come from two numbers in an array
		int Number = 11; 
		//calling function
		Console.WriteLine("Array = [ " + (string.Join(", ", Array)) + " ] and number = " + Number );
		Combination(Array, Number); 
	} 

	static void Combination(int[] Array, int FinalNumber)
	{ 
		//Hashtable is basically a datastructure to retain values of key-value pair.
		//It didn’t allow null for both key and value. You will get NullPointerException if you add null value.
		//It is synchronized. So it comes with its cost. Only one thread can access in one time

		//HashSet does not allow duplicate values. It provides add method
		//rather put method. You also use its contain method to check
		//whether the object is already available in HashSet. 
		//HashSet can be used where you want to maintain a unique list.
		HashSet<int> HashTable = new HashSet<int>(); 
		for (int i = 0; i < Array.Length; ++i) 
        {
			int NotPermanent = FinalNumber - Array[i]; 

			//If everything OK,then WriteLine
			if (HashTable.Contains(NotPermanent)) 
            { 
				Console.WriteLine(FinalNumber + " = [" + Array[i] + " + " + NotPermanent + "]; "); 
			} 
			HashTable.Add(Array[i]); 
		} 
	} 
} 