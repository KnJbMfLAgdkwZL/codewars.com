// Best travel
// https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa

function subArrays(arr) {
    if (arr.length === 1) return [arr];
    else {
        subarr = subArrays(arr.slice(1));
        return subarr.concat(subarr.map(e => e.concat(arr[0])), [[arr[0]]]);
    }
}

function filterByLength(arr, n) {
    const result = arr.filter(a => a.length == n);
    return result;
}

function chooseBestSum(maxDist, towns, arr) {
    let subsets = filterByLength(subArrays(arr), towns);
    let myDist = null;
    for (var a of subsets) {
        let sum = a.reduce((a, b) => a + b);
        if (sum <= maxDist && sum >= myDist) {
            myDist = sum;
        }
    }
    return myDist;
}