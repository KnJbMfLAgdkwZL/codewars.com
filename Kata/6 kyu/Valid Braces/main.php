<?php
// Valid Braces
// https://www.codewars.com/kata/5277c8a221e209d3f6000b56

function validBraces($braces)
{
    $hay = [
        '(' => ')',
        '[' => ']',
        '{' => '}'
    ];
    $bra = [];
    for ($i = 0; $i < strlen($braces); $i++) {
        $v = $braces[$i];
        if (in_array($v, array_keys($hay))) {
            $bra[] = $v;
            continue;
        } else if (count($bra) > 0) {
            $key = count($bra) - 1;
            $ned = $bra[$key];
            if ($hay [$ned] == $v) {
                array_splice($bra, $key, 1);
            } else {
                return false;
            }
        } else {
            return false;
        }
    }
    if (count($bra) == 0)
        return true;
    return false;
}
