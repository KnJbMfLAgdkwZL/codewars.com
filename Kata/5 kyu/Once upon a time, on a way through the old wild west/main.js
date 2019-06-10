// Once upon a time, on a way through the old wild west
// https://www.codewars.com/kata/550f22f4d758534c1100025a

function dirReduc(arr) {
    let res = [];
    arr.forEach(v => {
        if (res.length > 0) {
            let prv = res.pop();
            if (v === "NORTH" && prv === "SOUTH" ||
                v === "SOUTH" && prv === "NORTH" ||
                v === "WEST" && prv === "EAST" ||
                v === "EAST" && prv === "WEST") {
                return;
            }
            res.push(prv);
        }
        res.push(v);
    });
    return res;
}
