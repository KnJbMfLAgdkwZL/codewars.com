# https://www.codewars.com/kata/52fba66badcd10859f00097e
# Disemvowel Trolls

def disemvowel(str):
    print(str)
    import re
    str = re.sub(r"[aeiouAEIOU]", "", str)
    return str
