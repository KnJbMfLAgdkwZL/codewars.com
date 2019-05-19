<?php
# https://www.codewars.com/kata/544aed4c4a30184e960010f4
# Find the divisors!

function divisors($integer)
{
    $arr = [];
    for ($i = 2; $i <= $integer / 2; $i++) {
        $v = $integer / $i;
        if ($v == (int)$v) {
            $arr[] = $i;
        }
    }
    if (count($arr)) {
        return $arr;
    }
    return "{$integer} is prime";
}
