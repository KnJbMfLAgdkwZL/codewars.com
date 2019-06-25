<?php
// Can you get the loop ?
// https://www.codewars.com/kata/52a89c2ea8ddc5547a000863

function loop_size($node)
{
    $arr = [];
    for ($len = 0; true; $len++) {
        $next = $node->getNext();
        if (in_array($next, $arr, true))
            break;
        $node = $next;
        $arr [] = $next;
    }
    return $len - array_search($next, $arr, true);
}
