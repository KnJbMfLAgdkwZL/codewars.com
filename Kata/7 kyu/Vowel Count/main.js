// https://www.codewars.com/kata/54ff3102c1bad923760001f3
// Vowel Count

function getCount(str) {
    let vowels = ['a', 'e', 'i', 'o', 'u']
    var vowelsCount = 0;
    for (let k in str) {
        let v = str[k]
        if (vowels.indexOf(v) != -1)
            vowelsCount++
    }
    return vowelsCount;
}
