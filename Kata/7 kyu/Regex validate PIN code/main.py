# https://www.codewars.com/kata/55f8a9c06c018a0d6e000132
# Regex validate PIN code

import re


def validate_pin(pin):
    l = len(pin)
    if l == 4 or l == 6:
        regexp = re.compile(r"[^0-9]")
        if not regexp.search(pin):
            return True
    return False
