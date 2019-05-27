# IQ Test
# https://www.codewars.com/kata/552c028c030765286c00007d

def iq_test(numbers):
    even_count = odd_count = 0
    even_last = odd_last = ''
    numbers = numbers.split(' ')
    for v in numbers:
        if int(v) % 2 == 0:
            even_count += 1
            even_last = v
        else:
            odd_count += 1
            odd_last = v
    if even_count < odd_count:
        v = even_last
    else:
        v = odd_last
    return numbers.index(v) + 1
