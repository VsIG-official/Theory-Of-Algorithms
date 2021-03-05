using System; 


class Script 
{
    public static int Swap=0;
	public static int Swap1=0;
	public static int Swap2=0;
    public static void Main() 
	{ 
	int []Array = {10, 7, 8, 9, 1, 5}; 
	int []Array1 = {7, 8, 1, 9, 10, 5};
	int []Array2 = {5, 7, 9, 8, 1, 10};
	int Numbers = Array.Length; 
	Console.WriteLine("Arrays are : First = ");
	PrintArray(Array, Numbers);
	Console.WriteLine("second = ");
	PrintArray(Array1, Numbers);
	Console.WriteLine("and third = ");
	PrintArray(Array2, Numbers);

	QuickSort(Array, 0, Numbers-1);
	QuickSort1(Array1, 0, Numbers-1);
	QuickSort2(Array2, 0, Numbers-1);

	Console.WriteLine("Final array = ");
	PrintArray(Array, Numbers);
	Console.WriteLine("Final array1 = ");
	PrintArray(Array1, Numbers);
	Console.WriteLine("Final array2 = "); 
	PrintArray(Array2, Numbers);
	} 
	
	static int Split(int []Array, int Left, int Right) 
	{ 
		int CentralPoint = Array[Right]; 
		
		int i = (Left - 1); 
		for (int j = Left; j < Right; j++) 
		{ 
			Swap++;
            Console.WriteLine("Swaps = " + Swap);

			if (Array[j] < CentralPoint) 
			{ 
				i++; 

				int NotPermanent = Array[i]; 
				Array[i] = Array[j]; 
				Array[j] = NotPermanent; 
			} 
		} 


		int NotPermanent_1 = Array[i+1]; 
		Array[i+1] = Array[Right]; 
		Array[Right] = NotPermanent_1; 

		return i+1; 
	} 
	static int Split1(int []Array, int Left, int Right) 
	{ 
		int CentralPoint = Array[Right]; 

		int i = (Left - 1); 
		for (int j = Left; j < Right; j++) 
		{ 
			Swap1++;
            Console.WriteLine("Swaps1 = " + Swap1);

			if (Array[j] < CentralPoint) 
			{ 
				i++; 

				int NotPermanent = Array[i]; 
				Array[i] = Array[j]; 
				Array[j] = NotPermanent; 
			} 
		} 
		int NotPermanent_1 = Array[i+1]; 
		Array[i+1] = Array[Right]; 
		Array[Right] = NotPermanent_1; 

		return i+1; 
	} 
	static int Split2(int []Array, int Left, int Right) 
	{ 
		int CentralPoint = Array[Right]; 

		int i = (Left - 1); 
		for (int j = Left; j < Right; j++) 
		{ 
			Swap2++;
            Console.WriteLine("Swaps2 = " + Swap2);

			if (Array[j] < CentralPoint) 
			{ 
				i++; 

				int NotPermanent = Array[i]; 
				Array[i] = Array[j]; 
				Array[j] = NotPermanent; 
			} 
		} 
		int NotPermanent_1 = Array[i+1]; 
		Array[i+1] = Array[Right]; 
		Array[Right] = NotPermanent_1; 

		return i+1; 
	} 

	static void QuickSort(int []Array, int Left, int Right) 
	{ 
		if (Left < Right) 
		{ 			
			int SomeNumber = Split(Array, Left, Right); 

			QuickSort(Array, Left, SomeNumber-1); 
			QuickSort(Array, SomeNumber+1, Right); 
		} 
	} 

		static void QuickSort1(int []Array, int Left, int Right) 
	{ 
		if (Left < Right) 
		{ 			
			int SomeNumber = Split1(Array, Left, Right); 

			QuickSort1(Array, Left, SomeNumber-1); 
			QuickSort1(Array, SomeNumber+1, Right); 
		} 
	} 

		static void QuickSort2(int []Array, int Left, int Right) 
	{ 
		if (Left < Right) 
		{ 			
			int SomeNumber = Split2(Array, Left, Right); 

			QuickSort2(Array, Left, SomeNumber-1); 
			QuickSort2(Array, SomeNumber+1, Right); 
		} 
	} 

	static void PrintArray(int []Array, int Numbers) 
	{ 
		for (int i = 0; i < Numbers; ++i) 
		{
			Console.Write(Array[i] + " "); 
		}
		Console.WriteLine(); 
	} 
} 