<?php
// Not very secure
// https://www.codewars.com/kata/526dbd6c8c0eb53254000110

function alphanumeric(string $s): bool
{
    $pattern = '/^[a-zA-Z\d]+$/';
    return preg_match($pattern, $s);
}