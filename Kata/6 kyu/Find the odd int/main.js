// https://www.codewars.com/kata/54da5a58ea159efa38000836
// Find the odd int

function findOdd(A) {
    let data = {};

    A.forEach(function (v) {
        if (data[v]) {
            data[v]++;
        } else {
            data[v] = 1;
        }
    });

    let res = Object.keys(data).reduce(function (max, key) {

        if (data[key] % 2 !== 0) {
            return key;
        } else {
            return max;
        }
    });

    return parseInt(res);
}