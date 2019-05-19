<?php
# https://www.codewars.com/kata/563b662a59afc2b5120000c6
# Growth of a Population

function nbYear($p0, $percent, $aug, $p)
{
    $i = 0;
    while ($p0 < $p) {
        $p0 = $p0 + $p0 * $percent / 100 + $aug;
        $i++;
    }
    return $i;
}
