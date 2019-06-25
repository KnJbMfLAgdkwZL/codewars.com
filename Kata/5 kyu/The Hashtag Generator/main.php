<?php
// The Hashtag Generator
// https://www.codewars.com/kata/52449b062fb80683ec000024

function generateHashtag($str)
{
    $words = explode(' ', $str);
    foreach ($words as &$v)
        $v = ucfirst($v);
    $res = implode('', $words);
    if ($res && strlen($res) < 140)
        return "#{$res}";
    return false;
}
