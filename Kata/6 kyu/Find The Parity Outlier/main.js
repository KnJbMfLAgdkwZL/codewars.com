// https://www.codewars.com/kata/5526fc09a1bbd946250002dc
// Find The Parity Outlier

function findOutlier(integers) {
    let res = {
        'even': {
            count: 0,
            val: undefined
        },
        'odd': {
            count: 0,
            val: undefined
        },
    };
    integers.forEach(function (v) {
        if (v % 2 === 0) {
            res.even.val = v;
            res.even.count++;
        } else {
            res.odd.val = v;
            res.odd.count++;
        }
    });

    if (res.even.count < res.odd.count)
        return res.even.val;
    return res.odd.val;
}