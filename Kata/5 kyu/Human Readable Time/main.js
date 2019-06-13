// Human Readable Time
// https://www.codewars.com/kata/52685f7382004e774f0001f7

function humanReadable(seconds) {
    let t = [];
    t[2] = seconds % 60;
    t[1] = (seconds - t[2]) / 60 % 60;
    t[0] = (seconds - t[2] - t[1] * 60) / 60 / 60;
    for (let k in t)
        if (t[k] < 10)
            t[k] = `0${t[k]}`;
    return t.join(':');
}