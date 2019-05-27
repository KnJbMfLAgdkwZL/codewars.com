// Unlucky Days
// https://www.codewars.com/kata/56eb0be52caf798c630013c0

function unluckyDays(year) {
    let count = 0;
    for (let i = 0; i < 12; i++) {
        let date = new Date(year, i, 13, 12, 0);
        if (date.getDay() === 5) {
            count++;
        }
    }
    return count;
}
