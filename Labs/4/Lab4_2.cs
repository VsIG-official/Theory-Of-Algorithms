using System; 
	
class Lab4_2
{ 

public static void Main() 
    { 
	int []array = {12, 11, 13, 5, 6, 7}; 
	int N = array.Length; 

	Console.WriteLine("Given array: "); 
	WriteArray(array); 

	HeapSortAlgoritm(array, N); 

	Console.WriteLine("Sorted array: "); 
	WriteArray(array); 

    mediana(array,N);
    } 

static void HighHeap(int []array, int N) 
{ 
	for (int i = 1; i < N; i++) 
	{ 
		if (array[i] > array[(i - 1) / 2]) 
		{ 
			int j = i; 
	
			while (array[j] > array[(j - 1) / 2]) 
			{ 
				Swap(array, j, (j - 1) / 2); 
				j = (j - 1) / 2; 
			} 
		} 
	} 
} 

public static void Swap(int[] A, int i, int j) 
{ 
	int NotPermanent = A[i]; 
	A[i] = A[j]; 
	A[j] = NotPermanent; 
} 

static void WriteArray(int []array) 
{ 
	int N = array.Length; 
	for (int i = 0; i < N; i++) 
	Console.WriteLine(array[i] + " "); 
	Console.WriteLine(); 
} 


static void HeapSortAlgoritm(int []array, int N) 
{ 
	HighHeap(array, N); 

	for (int i = N - 1; i > 0; i--) 
	{ 
		Swap(array, 0, i); 
	
		int j = 0, index; 
	
		do
		{ 
			index = (2 * j + 1); 
	
			if (index < (i - 1) && array[index] < array[index + 1]) 
            {
                index++; 
            }
	
			if (index < i && array[j] < array[index])
            {
				Swap(array, j, index); 
            }
	
			j = index; 
	
		} 
        while (index < i); 
	} 
} 

static int[] mediana(int[] array,int N)
            {

				//ЗДЕСЬ ПРОБЛЕМА
                HeapSortAlgoritm(array,N);
				Console.Write(N);
                if (array.Length % 2 != 0)
                {
                    int tmp = array[Convert.ToInt32((array.Length - 1) / 2)];
                    int[] result = {tmp};
                    return result;
                } 
				else
                {
                    int tmp = array[Convert.ToInt32((array.Length - 1) / 2)];
                    int tmp1 = array[Convert.ToInt32((array.Length - 1) / 2) + 1];
                    int[] result = {tmp, tmp1};
                    return result;
                }
            }


} 