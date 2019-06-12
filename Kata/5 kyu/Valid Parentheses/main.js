// Valid Parentheses
// https://www.codewars.com/kata/52774a314c2333f0a7000688

function validParentheses(parens) {
    while (parens.length) {
        let prev = parens;
        parens = parens.replace('()', '');
        if (prev === parens)
            return false;
    }
    return true;
}