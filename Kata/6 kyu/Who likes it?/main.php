<?php
// Who likes it?
// https://www.codewars.com/kata/5266876b8f4bf2da9b000362

function likes($names)
{
    $count = count($names);
    if ($count == 0)
        return "no one likes this";
    if ($count == 1)
        return "{$names[0]} likes this";
    if ($count == 2)
        return "{$names[0]} and {$names[1]} like this";
    if ($count == 3)
        return "{$names[0]}, {$names[1]} and {$names[2]} like this";
    if ($count > 3) {
        $count -= 2;
        return "{$names[0]}, {$names[1]} and {$count} others like this";
    }
}
