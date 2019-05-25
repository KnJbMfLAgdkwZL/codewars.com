<?php
// Unique In Order
// https://www.codewars.com/kata/54e6533c92449cc251001667

function uniqueInOrder($iterable)
{
    if (is_string($iterable))
        $iterable = str_split($iterable);
    $res = [];
    $prev = false;
    foreach ($iterable as $v) {
        if ($prev != $v) {
            $res[] = $v;
            $prev = $v;
        }
    }
    return $res;
}
