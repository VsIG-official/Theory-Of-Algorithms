using System; 
  
public class BackPackClass 
{ 	
	//main function
    public static void Main_1() 
    {
        int []value = new int[]{20, 220, 300}; 
        int []weight = new int[]{20, 40, 30}; 
        int W = 50; 
        int n = 3; 
          
        Console.WriteLine(BackPack(W, weight, value, n)); 
    }      
	
    //Function that returns 
    //maximum of two numbers
    static int max(int a, int b)  
    { 
		if(a>b)
		{
			return a;
		}
		
		else
		{
			return b;
		}
    } 
      
    // Returns the maximum value that can  
    // be put in a knapsack of capacity W 
    static int BackPack(int W, int []weight, int []value, int n) 
    { 
          
        //if something went really wrong
        if (n == 0 || W == 0) 
        {
            return 0; 
        }
        // If weight of the n item is  
        // more than Backpack W, 
        // then this item is bad 
        if (weight[n-1] > W) 
		{
            return BackPack(W, weight, value, n-1); 
		} 
        // Return the maximum of two cases:  
        //1. n item included  
        //2. not included 
        else 
		{
			return max( value[n-1] + 
            BackPack(W-weight[n-1], weight, value, n-1), 
                   BackPack(W, weight, value, n-1)); 
    	} 
	}
} 