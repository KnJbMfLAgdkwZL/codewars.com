// https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9
// Shortest Word

function findShort(str) {
    words = str.split(' ')
    let min = words[0]
    words.forEach((v) => {
        if (v.length < min.length)
            min = v
    })
    return min.length
}
