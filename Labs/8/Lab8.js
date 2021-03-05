'use strict'

const values=[18,40,32,10];
const weights=[7,12,15,18];
const W=50;
const i=10;

maxKnapsack(values, weights, W, i);

function maxKnapsack(values, weights, W, i) 
{
    
    if (W === 0 || i === 0) 
    {
        return 0;
    }
    if (weights[i] > W)
    {
        //console.log(maxKnapsack(values, weights, W, i-1));
        return maxKnapsack(values, weights, W, i-1);
    }
    else
    {
        let included = values[i] + maxKnapsack(values, weights, W-weights[i], i-1);
        let excluded = maxKnapsack(values, weights, W, i-1);
        console.log(Math.max(included, excluded));
        return Math.max(included, excluded);
    }
    
}
