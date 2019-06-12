// Maximum subarray sum
// https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c

function maxSequence(arr) {
    let res = 0;
    for (let i = 0; i < arr.length; i++) {
        let sum = 0;
        for (let j = i; j < arr.length; j++) {
            sum += arr[j];
            if (res < sum)
                res = sum;
        }
    }
    return res;
}