<?php
// Consecutive strings
// https://www.codewars.com/kata/56a5d994ac971f1ac500003e

function longestConsec($strarr, $k)
{
    $n = count($strarr);
    if ($n === 0 || $k > $n || $k <= 0)
        return "";
    $res = '';
    for ($i = 0; $i < $n; $i++) {
        $sliced = array_slice($strarr, $i, $k);
        $newstr = implode('', $sliced);
        if (strlen($res) < strlen($newstr)) {
            $res = $newstr;
        }
    }
    return $res;
}
