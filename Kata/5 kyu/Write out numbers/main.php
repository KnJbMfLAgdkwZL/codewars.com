<?php
// Write out numbers
// https://www.codewars.com/kata/52724507b149fa120600031d

function number2words($num = false)
{
    if ($num == 0) return 'zero';
    $words = [];
    $list1 = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven',
        'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'
    ];
    $list2 = ['', 'ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];
    $list3 = ['', 'thousand'];
    $num_length = strlen($num);
    $levels = (int)(($num_length + 2) / 3);
    $max_length = $levels * 3;
    $num = substr('00' . $num, -$max_length);
    $num_levels = str_split($num, 3);
    for ($i = 0; $i < count($num_levels); $i++) {
        $levels--;
        $hundreds = (int)($num_levels[$i] / 100);
        $hundreds = ($hundreds ? $list1[$hundreds] . ' hundred' : '');
        $tens = (int)($num_levels[$i] % 100);
        $singles = '';
        if ($tens < 20) {
            $tens = ($tens ? ' ' . $list1[$tens] : '');
        } else {
            $tens = (int)($tens / 10);
            $tens = ' ' . $list2[$tens];

            $singles = (int)($num_levels[$i] % 10);
            if ($singles) $tens .= '-';
            $singles = $list1[$singles];
        }
        $words[] = $hundreds . $tens . $singles . (($levels && ( int )($num_levels[$i])) ? ' ' . $list3[$levels] : '');
    }
    $res = implode(' ', $words);
    $res = preg_replace('/[ ]+/', ' ', $res);
    return trim($res);
}
