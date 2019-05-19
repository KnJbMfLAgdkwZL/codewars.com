// https://www.codewars.com/kata/554b4ac871d6813a03000035
// Highest and Lowest

function highAndLow(numbers) {
    numbers = numbers.split(' ')
    let min = numbers[0]
    let max = numbers[0]
    numbers.forEach((n) => {
        n = parseInt(n)
        if (n > max)
            max = n
        if (n < min)
            min = n
    })
    return `${max} ${min}`
}
