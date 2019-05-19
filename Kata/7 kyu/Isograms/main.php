<?php
# https://www.codewars.com/kata/54ba84be607a92aa900000f1
# Isograms

function isIsogram($string)
{
    $string = strtolower($string);
    $data = [];
    for ($i = 0; $i < strlen($string); $i++) {
        $v = $string[$i];
        if (isset($data[$v]))
            return false;
        $data[$v] = true;;
    }
    return true;
}
