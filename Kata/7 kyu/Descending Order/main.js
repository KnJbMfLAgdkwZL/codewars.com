// https://www.codewars.com/kata/5467e4d82edf8bbf40000155
// Descending Order

function descendingOrder(n) {
    return parseInt(n.toString().split('').sort().reverse().join(''))
}
