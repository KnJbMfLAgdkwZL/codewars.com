<?php
// Integers: Recreation One
// https://www.codewars.com/kata/55aa075506463dac6600010d

function listSquared($m, $n)
{
    $res = [];
    for ($j = $m; $j <= $n; $j++) {
        $divisors = [];
        for ($i = 1; $i <= sqrt($j); $i++) {
            if ($j % $i == 0) {
                if ($j / $i == $i)
                    $divisors[] = $i * $i;
                else {
                    $divisors[] = $i * $i;
                    $v = $j / $i;
                    $divisors[] = $v * $v;
                }
            }
        }
        $sum = array_sum($divisors);
        $r = sqrt($sum);
        if ($r - intval($r) == 0) {
            $res[] = [$j, $sum];
        }
    }
    return $res;
}
