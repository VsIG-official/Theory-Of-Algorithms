'use strict'

const Matrix = 
	[
	[3, 7, 1, 12, 1],
	[9, 11, 2, 14, 3],
	[7, 6, 5, 4, 1],
	[12, 10, 11, 6, 3],
	];

	const Num = 3
	console.log(NumberOfInversions(Num,  Matrix));

function NumberOfInversions(X,  Matrix) 
{ 
	let N = Matrix[X].length;
	
	let Final = [];	
	for (const Line in Matrix) {	
		
		if (Line != X) 
		{

		let Column = 0;
		let ColumnArray = Matrix[Line].slice();
	
			for (let Y = 0; Y < N; Y++) 
			{
				for (let Z = 0; Z < N; Z++) 
				{
					if (Matrix[X][Y] === ColumnArray[Z]) 
					{
						if (Y != Z) 
						{
							let NotPermanent = ColumnArray[Y];
							ColumnArray[Y] = ColumnArray[Z];
							ColumnArray[Z] = NotPermanent;
							
							Column++
						};
					};
				};
			};
			Final.push([Line, Column]);		
		}
	}
    return Final.sort(Compare); 
} 

function Compare(a, b) {
	if (a[1] === b[1]) 
	{
        return 0;
    }
	else 
	{
        return (a[1] < b[1]) ? -1 : 1;
    }
}