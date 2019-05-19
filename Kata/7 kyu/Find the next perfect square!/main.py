# https://www.codewars.com/kata/56269eb78ad2e4ced1000013
# Find the next perfect square!

import math


def find_next_square(sq):
    b = math.sqrt(sq)
    if b - int(b) == 0:
        b += 1
        b *= b
        return b
    return -1
