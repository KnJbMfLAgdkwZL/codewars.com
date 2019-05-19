# https://www.codewars.com/kata/54c27a33fb7da0db0100040e
# You're a square!

import math


def is_square(n):
    if n >= 0:
        b = math.sqrt(n)
        if b - int(b) == 0:
            return True
    return False
