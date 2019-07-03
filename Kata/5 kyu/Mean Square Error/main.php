<?php
// Mean Square Error
// https://www.codewars.com/kata/51edd51599a189fe7f000015

function solution(array $a, array $b): float
{
    $res = 0;
    $len = count($a);
    for ($i = 0; $i < $len; $i++) {
        $t = $b[$i] - $a[$i];
        $res += $t * $t;
    }
    $res /= $len;
    return $res;
}
