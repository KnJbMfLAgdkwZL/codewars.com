// Can you get the loop ?
// https://www.codewars.com/kata/52a89c2ea8ddc5547a000863

function loop_size(node) {
    let arr = [];
    for (let len = 0; true; len++) {
        let next = node.getNext();
        let i = arr.indexOf(next);
        if (i !== -1)
            return len - i;
        node = next;
        arr.push(next);
    }
}
