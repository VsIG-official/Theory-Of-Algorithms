'use strict'

const array = [30, 19, 9, 15, 55, 24, 3, 78, 46, 41];
let EvenArr = [];
let OddArr = [];
let FinalArr = [];
//4 arrays(3 empty to insert integers)

function EvenOddArrayFunc(array){//sorting even and odd numbers in two arrays
    for (let i = 0; i < array.length; i++){
      if (array[i] % 2 === 0){
        EvenArr.push(array[i]);
      }
      else
      {
        OddArr.push(array[i]);
      }
    }
}

EvenOddArrayFunc(array);//calling function

function SortEven(Arr)//sort all the even numbers in ascending order
{
    Arr.sort(function(a, b){
        return a - b;
    });
    EvenArr = Arr;
}

SortEven(EvenArr);//calling function

function SortOdd(Arr)//sort all odd numbers in descending order
{
    Arr.sort(function(a, b){
        return b - a;
    });
    OddArr = Arr;
}

SortOdd(OddArr);//calling function

FinalArr = [...EvenArr, ...OddArr];
console.log(FinalArr);//final result