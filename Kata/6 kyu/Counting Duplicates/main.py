# Counting Duplicates
# https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1

def duplicate_count(text):
    res = 0
    text = text.lower()
    for v in text:
        if text.count(v) > 1:
            res += 1
            text = text.replace(v, '')
    return res
