# Take a Ten Minute Walk
# https://www.codewars.com/kata/54da539698b8a2ad76000228

def isValidWalk(walk):
    x = y = min = 0
    for v in walk:
        if v == 'n':
            y += 1
        if v == 's':
            y -= 1
        if v == 'e':
            x += 1
        if v == 'w':
            x -= 1
        min += 1
    if x == 0 and y == 0 and min == 10:
        return True
    return False
