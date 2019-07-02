<?php
// Is my friend cheating?
// https://www.codewars.com/kata/5547cc7dcad755e480000004

function removeNb($l)
{
    $sum = $l * $l / 2 + $l / 2;
    $res = [];
    for ($i = 1; $i <= $l; $i++) {
        $x = ($sum - $i) / ($i + 1);
        if (intval($x) == $x && $x <= $l)
            $res[] = [$i, $x];
    }
    return $res;
}
