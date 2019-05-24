// https://www.codewars.com/kata/556deca17c58da83c00002db
// Tribonacci Sequence

function tribonacci(signature, n) {
    for (let i = 0; signature.length < n; i++)
        signature.push(signature[i] + signature[i + 1] + signature[i + 2]);
    return signature.slice(0, n);
}