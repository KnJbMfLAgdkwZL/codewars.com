<?php
# https://www.codewars.com/kata/5656b6906de340bd1b0000ac
# Two to One

function longest($a, $b)
{
    $str = str_split($a . $b);
    sort($str);
    $str = array_unique($str);
    $str = implode('', $str);
    return $str;
}
