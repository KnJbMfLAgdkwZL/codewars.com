// https://www.codewars.com/kata/5679aa472b8f57fb8c000047
// Equal Sides Of An Array

function findEvenIndex(arr) {
    let sum_s = 0, sum_e = 0;
    for (let s = 0; s < arr.length; s++) {
        sum_s += arr[s];
        sum_e = 0;
        for (let e = s; e < arr.length; e++) {
            sum_e += arr[e];
        }
        if (sum_s === sum_e) {
            return s;
        }
    }
    return -1;
}