<?php
# https://www.codewars.com/kata/5813d19765d81c592200001a
# Don't give me five!

function dont_give_me_five($start, $end)
{
    $cnt = 0;
    for ($i = $start; $i <= $end; $i++) {
        if (strpos((string)$i, '5') === false) {
            $cnt++;
        }
    }
    return $cnt;
}
