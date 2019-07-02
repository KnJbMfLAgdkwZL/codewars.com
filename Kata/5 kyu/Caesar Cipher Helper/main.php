<?php
// Caesar Cipher Helper
// https://www.codewars.com/kata/526d42b6526963598d0004db


class CaesarCipher
{
    function __construct($s)
    {
        $this->alph = str_split('ABCDEFGHIJKLMNOPQRSTUVWXYZ');
        $this->s = $s;
    }

    function code($str, $op)
    {
        $res = '';
        $str = strtoupper($str);
        $str = str_split($str);
        foreach ($str as $v) {
            $i = array_search($v, $this->alph);
            if ($i === false) {
                $res .= $v;
                continue;
            }
            $i = array_search($v, $this->alph);
            $len = count($this->alph);
            if ($op == 'encode') {
                $i += $this->s;
                if ($i >= $len)
                    $i = $i % $len;
            } else if ($op == 'decode') {
                $i -= $this->s;
                if ($i < 0)
                    $i = $len + $i;
            }
            $res .= $this->alph[$i];
        }
        return $res;
    }

    function encode($str)
    {
        return $this->code($str, 'encode');
    }

    function decode($str)
    {
        return $this->code($str, 'decode');
    }
}