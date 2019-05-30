# Find the missing letter
# https://www.codewars.com/kata/5839edaa6754d6fec10000a2

def find_missing_letter(chars):
    alphabet = 'abcdefghijklmnopqrstuvwxyz'
    i = alphabet.find(chars[0])
    if i == -1:
        alphabet = alphabet.upper()
        i = alphabet.find(chars[0])
    for v in chars:
        if v != alphabet[i]:
            return alphabet[i]
        i += 1
