# Simple Encryption #1 - Alternating Split
# https://www.codewars.com/kata/57814d79a56c88e3e0000786

def decrypt(text, n):
    while n > 0:
        str = ''
        i = 0
        h = int(len(text) / 2)
        while i < h:
            str += text[h + i] + text[i]
            i += 1
        if len(text) % 2 != 0:
            str += text[len(text) - 1]
        text = str
        n -= 1
    if text:
        text = text.strip()
    return text


def encrypt(text, n):
    while n > 0:
        str1 = ''
        str2 = ''
        i = 0
        while i < len(text):
            if i % 2 != 0:
                str1 += text[i]
            else:
                str2 += text[i]
            i += 1
        text = str1 + str2
        n -= 1
    return text
