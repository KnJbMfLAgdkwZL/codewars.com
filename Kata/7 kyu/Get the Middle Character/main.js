// https://www.codewars.com/kata/56747fd5cb988479af000028
// Get the Middle Character

function getMiddle(str) {
    let centr = parseInt(str.length / 2);
    let res = str[centr];
    if (str.length % 2 == 0)
        res = str[centr - 1] + res
    return res;
}
