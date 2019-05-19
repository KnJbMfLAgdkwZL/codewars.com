# https://www.codewars.com/kata/5412509bd436bd33920011bc
# Credit Card Mask
def maskify(cc):
    l = len(cc)
    if l < 4:
        return cc

    res = ''
    i = 0
    while i < l - 4:
        res += '#'
        i += 1
    res += cc[l - 4:l]

    return res
