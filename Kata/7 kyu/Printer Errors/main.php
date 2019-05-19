<?php
# https://www.codewars.com/kata/56541980fa08ab47a0000040
# Printer Errors

function printerError($s)
{
    $errors = preg_match_all('/[^a-m]/', $s);
    $len = strlen($s);
    $res = "{$errors}/$len";
    return $res;
}
