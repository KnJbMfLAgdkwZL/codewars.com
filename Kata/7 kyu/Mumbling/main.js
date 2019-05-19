// https://www.codewars.com/kata/5667e8f4e3f572a8f2000039
// Mumbling

function accum(str) {
    let arr = [];

    for (let k in str) {
        let v = str[k];

        let tmp = '';

        for (let i = 0; i <= arr.length; i++) {
            tmp += v;
        }

        tmp = tmp.toLowerCase();
        tmp = tmp.charAt(0).toUpperCase() + tmp.slice(1);

        arr.push(tmp);
    }

    return arr.join('-');
}
