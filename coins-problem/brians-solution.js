scale = require("./scale")

function badSolution(scale) {
    return 7
}

function weighAllPairs(scale) {
    let c = 0
    for(let i = 1;i < scale.numberOfCoins; i++){
        var result = scale.weigh([c],[i])
        if (result == "side2") {
            return c
        } 
        else if (result == "side1")
        {
            return i
        }
    }
}

function gimmeCoins(offset, neededLength){
    // let offset = 2;
    // let neededLength = 5;
    
    return Array.from({length: neededLength}, (v,i) => offset + i);
}

function divideAndConquer(scale) {
    let initialCoins = gimmeCoins(0,scale.numberOfCoins);

    return innerDvideAndConquer(scale, initialCoins);
}

function innerDvideAndConquer(scale, coinStack){

    let currentStack = coinStack;
    let oddCoinIndex = -1;
    //Grab odd coin and make new stack:
    if(currentStack.length %2 === 1){
        oddCoinIndex = currentStack[0];
        currentStack = gimmeCoins(currentStack[1], currentStack.length -1);
    }


    let side1 = gimmeCoins(currentStack[0], currentStack.length /2);
    let side2 = gimmeCoins(currentStack[currentStack.length /2], currentStack.length /2);
    //Check if we get an even stack, if we do return with the odd coin index:
    var scaleOutcome = scale.weigh(side1, side2);

    if(scaleOutcome === "equal"){
        return oddCoinIndex;
    }

    if(currentStack.length === 2)
    {
        if(scaleOutcome === "side2"){
            return side1[0];
        }

        if(scaleOutcome === "side1"){
            return side2[0];
        }
    }

    if(scaleOutcome === "side2"){
        return innerDvideAndConquer(scale, side1);
    }

    if(scaleOutcome === "side1"){
        return innerDvideAndConquer(scale, side2);
    }
}

function DvideAndConquer_NoRecursion(scale, coinStack){
    
        let currentStack = gimmeCoins(0,scale.numberOfCoins);
        
        while(true)
        {
            let oddCoinIndex = -1;
            //Grab odd coin and make new stack:
            if(currentStack.length %2 === 1){
                oddCoinIndex = currentStack[0];
                currentStack = gimmeCoins(currentStack[1], currentStack.length -1);
            }
        
            let side1 = gimmeCoins(currentStack[0], currentStack.length /2);
            let side2 = gimmeCoins(currentStack[currentStack.length /2], currentStack.length /2);
            //Check if we get an even stack, if we do return with the odd coin index:
            var scaleOutcome = scale.weigh(side1, side2);
        
            if(scaleOutcome === "equal"){
                return oddCoinIndex;
            }
        
            if(currentStack.length === 2)
            {
                if(scaleOutcome === "side2"){
                    return side1[0];
                }
        
                if(scaleOutcome === "side1"){
                    return side2[0];
                }
            }
        
            if(scaleOutcome === "side2"){
                currentStack = side1;
            }
        
            if(scaleOutcome === "side1"){
                currentStack = side2;
            }
        }
    }

console.log("DvideAndConquer_NoRecursion")
scale.testLevel1Solution(DvideAndConquer_NoRecursion)