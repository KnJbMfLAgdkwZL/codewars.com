// Simple Pig Latin
// https://www.codewars.com/kata/520b9d2ad5c005041100000f

function pigIt(str) {
    let letters = /^[A-Za-z]+$/;
    let words = str.split(' ');
    for (let k in words) {
        let v = words[k];
        if (v.match(letters)) {
            words[k] = v.substring(1) + v[0] + 'ay';
        }
    }
    return words.join(' ');
}