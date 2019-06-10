// Calculating with Functions
// https://www.codewars.com/kata/525f3eda17c7cd9f9e000b39

function zero(v) {
    if (v)
        return parseInt(eval(0 + v));
    return 0;
}

function one(v) {
    if (v)
        return parseInt(eval(1 + v));
    return 1;
}

function two(v) {
    if (v)
        return parseInt(eval(2 + v));
    return 2;
}

function three(v) {
    if (v)
        return parseInt(eval(3 + v));
    return 3;
}

function four(v) {
    if (v)
        return parseInt(eval(4 + v));
    return 4;
}

function five(v) {
    if (v)
        return parseInt(eval(5 + v));
    return 5;
}

function six(v) {
    if (v)
        return parseInt(eval(6 + v));
    return 6;
}

function seven(v) {
    if (v)
        return parseInt(eval(7 + v));
    return 7;
}

function eight(v) {
    if (v)
        return parseInt(eval(8 + v));
    return 8;
}

function nine(v) {
    if (v)
        return parseInt(eval(9 + v));
    return 9;
}

function plus(v = '') {
    return '+' + v;
}

function minus(v = '') {
    return '-' + v;
}

function times(v = '') {
    return '*' + v;
}

function dividedBy(v = '') {
    return '/' + v;
}
