// https://www.codewars.com/kata/55f2b110f61eb01779000053
// Beginner Series #3 Sum of Numbers

function GetSum(a, b) {
    let sum = 0;

    if (a > b) {
        let t = a;
        a = b;
        b = t;
    }

    for (; a <= b; a++) {
        sum += a;
    }
    return sum;
}
