using System; 
	
class Lab4_1
{ 

static void HighHeap(int []Array, int N) 
{ 
	for (int i = 1; i < N; i++) 
	{ 
		if (Array[i] > Array[(i - 1) / 2]) 
		{ 
			int j = i; 
	
			while (Array[j] > Array[(j - 1) / 2]) 
			{ 
				Swap(Array, j, (j - 1) / 2); 
				j = (j - 1) / 2; 
			} 
		} 
	} 
} 

static void HeapSortAlgoritm(int []Array, int N) 
{ 
	HighHeap(Array, N); 

	for (int i = N - 1; i > 0; i--) 
	{ 
		Swap(Array, 0, i); 
	
		int j = 0, index; 
	
		do
		{ 
			index = (2 * j + 1); 
	
			if (index < (i - 1) && Array[index] < Array[index + 1]) 
			index++; 
	
			if (index < i && Array[j] < Array[index]) 
				Swap(Array, j, index); 
	
			j = index; 
	
		} while (index < i); 
	} 
} 

public static void Swap(int[] A, int i, int j) 
{ 
	int NotPermanent = A[i]; 
	A[i] = A[j]; 
	A[j] = NotPermanent; 
} 

static void WriteArray(int []Array) 
{ 
	int N = Array.Length; 
	for (int i = 0; i < N; i++) 
	Console.WriteLine(Array[i] + " "); 
	Console.WriteLine(); 
} 

public void Main(String []args, int[] ArrayFinal) 
    { 
	int []Array = {12, 11, 13, 5, 6, 7}; 
	int N = Array.Length; 

	Console.WriteLine("Given array: "); 
	WriteArray(Array); 

	HeapSortAlgoritm(Array, N); 

	Console.WriteLine("Sorted array: "); 
	WriteArray(Array); 

    //КОД ДЛЯ ЗНАХОДЖЕННЯ МЕДІАН ЗНАХОДИТЬСЯ ТУТА




    // if ((Array.Length % 2) != 0 )
    // {
    //     int [] ArrayFinal = new int []Array[((Array.Length-1)/2) ]
    // }

    // else
    // {

    // }



    //     if len(array) % 2 != 0:
    //     return array[int((len(array)-1) / 2)]
    // else:
    //     return [array[int((len(array)-1) / 2)], array[int((len(array)-1) / 2) + 1]]
    } 
} 