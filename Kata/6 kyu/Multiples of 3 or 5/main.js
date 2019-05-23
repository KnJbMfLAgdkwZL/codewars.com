// https://www.codewars.com/kata/514b92a657cdc65150000006
// Multiples of 3 or 5

function solution(number) {
    let sum = 0;
    for (let i = 0; i < number; i++) {
        if (i % 3 === 0 || i % 5 === 0) {
            sum += i;
        }
    }
    return sum;
}