// https://www.codewars.com/kata/541c8630095125aba6000c00
// Sum of Digits / Digital Root

function digital_root(n) {
    let str = n.toString();
    while (str.length > 1) {
        let sum = 0;
        for (let k in str) {
            sum += parseInt(str[k]);
        }
        str = sum.toString();
    }
    return parseInt(str);
}