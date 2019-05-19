<?php
# https://www.codewars.com/kata/578553c3a1b8d5c40300037c
# Ones and Zeros

function binaryArrayToNumber($arr)
{
    $sum = 0;
    $arr = array_reverse($arr);
    foreach ($arr as $k => $v) {
        if ($v) {
            if ($k == 0) {
                $sum++;
            } else {
                $sum += pow(2, $k);
            }
        }
    }
    return $sum;
}
