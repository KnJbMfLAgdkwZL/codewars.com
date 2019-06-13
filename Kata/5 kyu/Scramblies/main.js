// Scramblies
// https://www.codewars.com/kata/55c04b4cc56a697bb0000048

function scramble(str1, str2) {
    let counter = {};
    for (let v of str1) {
        if (!counter[v])
            counter[v] = 0;
        counter[v]++;
    }
    for (let v of str2) {
        if (!counter[v])
            return false;
        counter[v]--;
    }
    return true;
}