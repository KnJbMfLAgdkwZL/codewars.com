<?php
// Gap in Primes
// https://www.codewars.com/kata/561e9c843a2ef5a40c0000a4

function is_prime($number)
{
    if ($number == 1)
        return false;
    for ($i = 2; $i <= sqrt($number); $i++)
        if ($number % $i == 0)
            return false;
    return true;
}

function gap($g, $m, $n)
{
    $prev = 0;
    for ($i = $m; $i < $n; $i++)
        if (is_prime($i)) {
            if ($i - $prev == $g)
                return [$prev, $i];
            $prev = $i;
        }
    return null;
}
