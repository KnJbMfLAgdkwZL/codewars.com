<?php
// Bit Counting
// https://www.codewars.com/kata/526571aae218b8ee490006f4

function countBits($n)
{
    $binString = decbin($n);
    return substr_count($binString, '1');
}
