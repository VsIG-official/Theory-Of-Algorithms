using System; 

public class Lab4 
{ 
	public void HeapSort(int[] Array) 
	{ 
		int N = Array.Length; 

		for (int i = N / 2 - 1; i >= 0; i--) 
			HeapAlgoritm(Array, N, i); 

		for (int i=N-1; i>=0; i--) 
		{ 
			int NotPermanent = Array[0]; 
			Array[0] = Array[i]; 
			Array[i] = NotPermanent; 

			HeapAlgoritm(Array, i, 0); 
		} 
	} 

	void HeapAlgoritm(int[] Array, int N, int i) 
	{ 
		int Biggest = i; 
		int Left = 2*i + 1; 
		int Right = 2*i + 2; 

		if (Left < N && Array[Left] > Array[Biggest]) 
			Biggest = Left; 

		if (Right < N && Array[Right] > Array[Biggest]) 
			Biggest = Right; 

		if (Biggest != i) 
		{ 
			int Swap = Array[i]; 
			Array[i] = Array[Biggest]; 
			Array[Biggest] = Swap; 

			HeapAlgoritm(Array, N, Biggest); 
		} 
	} 

	static void printArray(int[] Array) 
	{ 
		int N = Array.Length; 
		for (int i=0; i<N; ++i) 
			Console.Write(Array[i]+" "); 
		Console.Read(); 
	} 

	public static void Main() 
	{ 
		int[] Array = {12, 11, 13, 5, 6, 7}; 
		int N = Array.Length; 

		Lab4 ob = new Lab4(); 
		ob.HeapSort(Array); 

		Console.WriteLine("Sorted array is"); 
		printArray(Array); 
	} 
} 