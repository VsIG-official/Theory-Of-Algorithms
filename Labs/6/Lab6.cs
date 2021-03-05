using System; 
using System.Collections.Generic; 

class BinaryTree 
{
	class Vertex 
	{
        //index in vertex
		public int Information; 
        //creating two parts of the vertex
		public Vertex LeftPart, RightPart; 
	}

	public static void Main(String[] Arguments) 
	{
        //making binary tree
		Vertex Parent = null; 
		Parent = insert(Parent, 11); 
		Parent = insert(Parent, 0); 
		Parent = insert(Parent, 25); 
		Parent = insert(Parent, 1); 
		Parent = insert(Parent, 20); 
		Parent = insert(Parent, 14); 
		Parent = insert(Parent, 5); 
		Parent = insert(Parent, 31); 

        //number,which we need to find
		int FinalNumber = 19; 
		FindCombination(Parent, FinalNumber); 
	} 

	static Vertex NewVertex(int Information)
	{
		Vertex NotPermanent = new Vertex();
		NotPermanent.Information = Information;
        //dont make new children
		NotPermanent.LeftPart = null;
		NotPermanent.RightPart = null;
		return NotPermanent;
	}

	static Vertex insert(Vertex Parent, int Key) 
	{ 
		if (Parent == null)
        {
            //theres no numbers
			return NewVertex(Key); 
        }

		if (Key < Parent.Information) 
        {
            //left wing of the tree is always<than the parent
			Parent.LeftPart = insert(Parent.LeftPart, Key); 
        }

		else
        {
            //right wing of the tree is always>than the parent
			Parent.RightPart = insert(Parent.RightPart, Key); 
        }

		return Parent; 
	} 

	static bool FindCombinationSecond(Vertex Parent, int FinalNumber, HashSet<int> Combination) 
	{ 
		if (Parent == null)
        {
            //starting vertex
			return false; 
        }

        //we are inserting vertex value into combination
        //checking difference between giving FinalNumber and vertex value in combination
        //if it is found,then combination exists,otherwise-no

		if (FindCombinationSecond(Parent.LeftPart, FinalNumber, Combination)) 
        {
            //these are vertexes,which go further
			return true; 
        }

		if (Combination.Contains(FinalNumber - Parent.Information))
		{
            //for example "19-11=8" and showing final combination
			Console.WriteLine("One of the combinations is [" + (FinalNumber - Parent.Information) + ", " + Parent.Information + "]"); 
			return true;
		}

		else
        {
			Combination.Add(Parent.Information);
        }

		return FindCombinationSecond(Parent.RightPart, FinalNumber, Combination);
	}

	static void FindCombination(Vertex Parent, int FinalNumber)
	{
		HashSet<int> Combination = new HashSet<int>();
		if (!FindCombinationSecond(Parent, FinalNumber, Combination))
        {
            //if everything went really wrong
			Console.WriteLine("There's no combinations :(");
        }
    }
}