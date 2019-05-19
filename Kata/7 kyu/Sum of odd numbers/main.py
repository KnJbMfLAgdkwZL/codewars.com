# https://www.codewars.com/kata/55fd2d567d94ac3bc9000064
# Sum of odd numbers

def row_sum_odd_numbers(n):
    s = 0
    i = 1
    j = 0

    while j < n - 1:
        s += 2
        i += s
        j += 1

    start = i
    end = i + (s + 2)
    sum = 0
    while start < end:
        sum += start
        start += 2

    return sum
