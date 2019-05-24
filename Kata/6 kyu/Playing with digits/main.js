// https://www.codewars.com/kata/5552101f47fc5178b1000050
// Playing with digits

function digPow(n, p) {
    let str = n.toString();
    let res = 0;
    for (let i = 0; i < str.length; i++) {
        let v = parseInt(str[i]);
        let sum = 1;
        for (let j = 0; j < i + p; j++) {
            sum *= v;
        }
        res += sum;
    }
    let k = 0;
    while (n * k < res) {
        k++;
        if (n * k === res)
            return k;
    }
    return -1;
}