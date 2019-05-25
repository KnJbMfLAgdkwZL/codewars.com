<?php
// Duplicate Encoder
// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c

function duplicate_encode($word)
{
    $word = strtolower($word);
    $len = strlen($word);
    $res = '';
    for ($i = 0; $i < $len; $i++) {
        if (substr_count($word, $word[$i]) <= 1)
            $res .= '(';
        else
            $res .= ')';
    }
    return $res;
}
