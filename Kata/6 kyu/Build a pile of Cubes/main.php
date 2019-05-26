<?php
// Build a pile of Cubes
// https://www.codewars.com/kata/5592e3bd57b64d00f3000047

function findNb($m)
{
    for ($i = 0, $sum = 0; $sum < $m; $i++) {
        $sum += $i * $i * $i;
    }
    if ($sum == $m) {
        return $i - 1;
    }
    return -1;
}
