// Weight for weight
// https://www.codewars.com/kata/55c6126177c9441a570000cc

function orderWeight(strng) {
    let data = strng.split(' ');
    data.sort(function (a, b) {
        let sum_a = 0;
        for (let v of a)
            sum_a += parseInt(v);
        let sum_b = 0;
        for (let v of b)
            sum_b += parseInt(v);
        if (sum_a < sum_b)
            return -1;
        if (sum_a > sum_b)
            return 1;
        if (a > b)
            return 1;
        else
            return -1;
    });
    return data.join(' ');
}