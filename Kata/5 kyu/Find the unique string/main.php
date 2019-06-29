<?php
// Find the unique string
// https://www.codewars.com/kata/585d8c8a28bc7403ea0000c3

function find_uniq($a)
{
    $res = [];
    foreach ($a as $v) {
        $v1 = array_unique(str_split(strtolower($v)));
        sort($v1);
        $v1 = implode($v1, '');
        if (!isset($res[$v1]))
            $res[$v1] = [];
        $res[$v1][] = $v;
    }
    foreach ($res as $k => $v)
        if (count($v) == 1)
            return $v[0];
}
