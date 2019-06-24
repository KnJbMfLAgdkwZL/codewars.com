<?php
// Where my anagrams at?
// https://www.codewars.com/kata/523a86aa4230ebb5420001e1

function anagrams($word, $words)
{
    $res = [];
    $word = str_split($word);
    sort($word);
    $word = implode('', $word);
    foreach ($words as $v) {
        $str = str_split($v);
        sort($str);
        $str = implode('', $str);
        if ($word == $str) {
            $res[] = $v;
        }
    }
    return $res;
}
