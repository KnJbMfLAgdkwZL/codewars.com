// https://www.codewars.com/kata/5264d2b162488dc400000001
// Stop gninnipS My sdroW!

function spinWords(str) {
    let data = str.split(' ');
    for (let k in data) {
        let v = data[k];
        if (v.length >= 5) {
            data[k] = v.split('').reverse().join('');
        }
    }
    return data.join(' ');
}