using System; 

class Lab7
{ 

// Find the fastest path
static int TravellingSalesmanProblem(int [,]Graph, bool []ArrayVertexes, 
		int PresentPosition, int Vertex, 
		int Total, int Price, int FinalResult) 
{

	if (Total == Vertex && Graph[PresentPosition,0] > 0) 
	{ 
		FinalResult = Math.Min(FinalResult, Price + Graph[PresentPosition,0]); 
		return FinalResult; 
	} 

	for (int i = 0; i < Vertex; i++) { 
		if (ArrayVertexes[i] == false && Graph[PresentPosition,i] > 0) 
		{ 

			// Mark as visited 
			ArrayVertexes[i] = true; 
			FinalResult = TravellingSalesmanProblem(Graph, ArrayVertexes, i, Vertex, Total + 1, 
				Price + Graph[PresentPosition,i], FinalResult); 

			// Mark i-th node as unvisited 
			ArrayVertexes[i] = false; 
		} 
	} 
	return FinalResult; 
} 

static void Main() 
{ 
	// Vertex = number of vertexes
	int Vertex = 6; 

	int [,]Graph = 
	{ 
		{ 0, 75, 5, 15, 25, 40}, 
		{ 15, 0, 55, 15, 10,75 }, 
		{ 35, 25, 0, 10 ,10,5}, 
		{ 40, 15, 45, 0 ,25,35}, 
		{ 15, 25, 20, 10 ,0,20},
		{ 50, 5, 5, 95 ,25,0}
	}; 

	//if the vertex was visited
	bool[] ArrayVertexes = new bool[Vertex]; 

	// 0th vertex is visited 
	ArrayVertexes[0] = true; 
	int FinalResult = int.MaxValue; 

	// Setting the value
	FinalResult = TravellingSalesmanProblem(Graph, ArrayVertexes, 0, Vertex, 1, 0, FinalResult); 

	// FinalResult is the minimum weight Hamiltonian Cycle 
	Console.WriteLine(FinalResult); 
    } 
} 