<?php
// Replace With Alphabet Position
// https://www.codewars.com/kata/546f922b54af40e1e90001da

function alphabet_position(string $s): string
{
    $alphabets = ['A' => 1, 'B' => 2, 'C' => 3, 'D' => 4, 'E' => 5, 'F' => 6, 'G' => 7, 'H' => 8, 'I' => 9, 'J' => 10, 'K' => 11, 'L' => 12, 'M' => 13, 'N' => 14, 'O' => 15, 'P' => 16, 'Q' => 17, 'R' => 18, 'S' => 19, 'T' => 20, 'U' => 21, 'V' => 22, 'W' => 23, 'X' => 24, 'Y' => 25, 'Z' => 26];
    $res = [];
    for ($i = 0; $i < strlen($s); $i++) {
        $v = $s[$i];
        $k = strtoupper($v);
        if (isset($alphabets[$k]))
            $res[] = $alphabets[$k];
    }
    return implode(' ', $res);
}
