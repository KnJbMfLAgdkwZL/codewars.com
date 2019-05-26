<?php
// Array.diff
// https://www.codewars.com/kata/523f5d21c841566fde000009

function arrayDiff($a, $b)
{
    $res = [];
    foreach ($a as $v) {
        if (!in_array($v, $b)) {
            $res[] = $v;
        }
    }
    return $res;
}
