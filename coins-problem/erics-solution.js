scale = require("./scale")

function FindFakes(scale) {
    if (scale.numberOfCoins <= 1) {
        return 0;
    }
    var fakes = [];
    var begin = 0;
    var end = scale.numberOfCoins -1;
    var valid = -1;
    var equals = []
    while (begin < end) {
        var result = scale.weigh([begin], [end]);
        if (result === 'side1') {
            fakes.push(end);
            valid = begin;
        }
        if (result === 'side2') {
            fakes.push(begin);
            valid = end;
        }
        if (result === 'equal'){
            if (valid != -1) {
                if (scale.weigh([valid], [begin]) !== 'equal') {
                    fakes.push(begin);
                    fakes.push(end);   
                }
            }
            else{
                equals.push(begin);
                equals.push(end);    
            }
        }
        begin++;
        end--;
    }
    if (begin === end) {
        if (valid === -1) { //three coins and first pair was equal.
            var result = scale.weigh([begin], [begin-1]);
            if (result === 'side1') {
                fakes.push(begin+1)
            }
            if (result === 'side2'){
                fakes.push(begin);
            }
            if (result === 'equal') {
                fakes.push(end+1);
            }
        }else{
            var result = scale.weigh([valid], [begin]);
            if (result !== 'equal') {
                fakes.push(begin);
            }    
        }
    }
    if (equals.length > 1) {
        var begin = 0;
        var end = equals.length-1;
        while (begin < end) {
            var result = scale.weigh([valid], [equals[begin]]);
            if (result !== 'equal') {
                fakes.push(equals[begin]);
                fakes.push(equals[begin + 1]);
            }
            begin = begin + 2;
        }            
    }
    return fakes[0];
}

console.log("FindFakes")
scale.testLevel1Solution(FindFakes)

// 2: CORRECT - MAX: 1
// 3: CORRECT - MAX: 3
// 4: CORRECT - MAX: 3
// 5: CORRECT - MAX: 5
// 8: CORRECT - MAX: 7
// 9: CORRECT - MAX: 9
// 16: CORRECT - MAX: 15
// 17: CORRECT - MAX: 17
// 25: CORRECT - MAX: 25
// 36: CORRECT - MAX: 35
// 100: CORRECT - MAX: 99