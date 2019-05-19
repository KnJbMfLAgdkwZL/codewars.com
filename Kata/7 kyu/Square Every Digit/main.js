// https://www.codewars.com/kata/546e2562b03326a88e000020
// Square Every Digit

function squareDigits(num) {
    return parseInt(num.toString().split('').map((n) => {
        return n * n
    }).join(''))
}
