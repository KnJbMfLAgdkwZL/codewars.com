// Sum of Pairs
// https://www.codewars.com/kata/54d81488b981293527000c8f

function sum_pairs(ints, s) {
    let arr = [];
    let counter = {};
    for (let k in ints) {
        let v = ints[k];
        if (!counter[v])
            counter[v] = 0;
        counter[v]++;
        if (counter[v] <= 2)
            arr.push(v);
    }
    let res = undefined;
    let size = arr.length;
    for (let k1 = 0; k1 < arr.length; k1++) {
        let v1 = arr[k1];
        for (let k2 = k1 + 1; k2 < arr.length; k2++) {
            let v2 = arr[k2];
            if (v1 + v2 === s) {
                if (size > k2 - k1) {
                    size = k2 - k1;
                    res = [v1, v2];
                    if (size <= 1)
                        return res;
                }
            }
        }

    }
    return res;
}