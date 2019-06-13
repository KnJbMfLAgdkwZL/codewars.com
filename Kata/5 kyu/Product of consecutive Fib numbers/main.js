// Product of consecutive Fib numbers
// https://www.codewars.com/kata/5541f58a944b85ce6d00006a

function productFib(prod) {
    for (let i = 1, p = 1; i <= prod;) {
        let t = i;
        i += p;
        p = t;
        if (t * i >= prod)
            return [t, i, t * i === prod];
    }
}