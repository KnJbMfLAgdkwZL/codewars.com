// https://www.codewars.com/kata/55908aad6620c066bc00002a
// Exes and Ohs

function XO(str) {
    let x = 0, o = 0
    str = str.toLowerCase()
    for (let k in str) {
        let v = str[k]
        if (v == 'x')
            x++
        if (v == 'o')
            o++
    }
    return x == o
}
