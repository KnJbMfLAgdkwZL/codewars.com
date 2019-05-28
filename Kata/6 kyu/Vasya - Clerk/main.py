# Vasya - Clerk
# https://www.codewars.com/kata/555615a77ebc7c2c8a0000b8

def tickets(people):
    cash = {}
    for v in people:
        if cash.get(v):
            cash[v] += 1
        else:
            cash[v] = 1
        if v > 25:
            change = v - 25
            i = 0
            while change > 0:
                keys = cash.keys()
                keys = sorted(keys, reverse=True)
                c = keys[i]
                if c <= change and cash[c] > 0:
                    cash[c] -= 1
                    change -= c
                else:
                    i += 1
                if i >= len(keys):
                    return "NO"
    return "YES"
