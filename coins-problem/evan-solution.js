scale = require("./scale")

function GroupByThirdsSolution(scale, recursedArray) {
    
        var splitter = function(size){ // creates array from int size
            let result = new Array(size);
            for (var i = 0; i < size; i++) {
                result[i] = i;      
            }
            return splicer(result);
        }
        var splicer = function(array){ // slices arrays into 3 chunks
            let arraySize = array.length;
            let a1 = array;
            let a2 = a1.splice(Math.round(arraySize / 3))
            let a3 = a2.splice(Math.round(arraySize / 3))
            return [a1,a2,a3]
        }
        var weigher = function(scale, recursedArray){
            let bagOfCoins = recursedArray || splitter(scale.numberOfCoins)
            
            let result = scale.weigh(bagOfCoins[0],bagOfCoins[1])
        
            if(result == "side2"){ // this means coin is in side1
                if(bagOfCoins[0].length == 1) return bagOfCoins[0][0];
                return weigher(scale, splicer(bagOfCoins[0]))
            } 
            if(result == "side1"){ // this means coin is in side2
                if(bagOfCoins[1].length == 1) return bagOfCoins[1][0];
                return weigher(scale, splicer(bagOfCoins[1]))
            } 
            if(result == "equal"){ // this means coin was in group3
                if(bagOfCoins[2].length == 1) return bagOfCoins[2][0];
                return weigher(scale, splicer(bagOfCoins[2])) 
            }
        }
    
        return weigher(scale);
    }

    scale.testLevel1Solution(GroupByThirdsSolution);

    // 2: CORRECT - MAX: 1
    // 3: CORRECT - MAX: 1
    // 4: CORRECT - MAX: 2
    // 5: CORRECT - MAX: 2
    // 8: CORRECT - MAX: 2
    // 9: CORRECT - MAX: 2
    // 16: CORRECT - MAX: 3
    // 17: CORRECT - MAX: 3
    // 25: CORRECT - MAX: 3
    