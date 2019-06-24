<?php
// RGB To Hex Conversion
// https://www.codewars.com/kata/513e08acc600c94f01000001

function rgb($r, $g, $b)
{
    $rgb = [$r, $g, $b];
    foreach ($rgb as &$v) {
        $v = ($v < 0) ? 0 : $v;
        $v = ($v > 255) ? 255 : $v;
        $v = dechex($v);
        $v = (strlen($v) < 2) ? "0{$v}" : $v;
        $v = strtoupper($v);
    }
    return implode('', $rgb);
}
