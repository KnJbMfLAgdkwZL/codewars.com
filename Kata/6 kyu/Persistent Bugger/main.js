// https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec
// Persistent Bugger

function persistence(num) {
    let res = 0;
    let str = num.toString();
    while (str.length > 1) {
        let sum = 1;
        for (let k in str) {
            sum *= parseInt(str [k]);
        }
        str = sum.toString();
        res++;
    }
    return res;
}