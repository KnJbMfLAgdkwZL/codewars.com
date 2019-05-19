<?php
# https://www.codewars.com/kata/555eded1ad94b00403000071
# Sum of the first nth term of Series

function series_sum($n)
{
    $sum = 0;
    for ($i = 0; $i < $n; $i++) {
        $sum += 1 / (1 + $i * 3);
    }
    $sum = number_format($sum, 2);
    return "{$sum}";
}
