<?php
# https://www.codewars.com/kata/5648b12ce68d9daa6b000099
# Number of People in the Bus

function number($bus_stops)
{
    $sum = 0;
    foreach ($bus_stops as $v) {
        $sum += $v[0];
        $sum -= $v[1];
    }
    return $sum;
}
