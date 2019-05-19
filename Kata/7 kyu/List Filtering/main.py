# https://www.codewars.com/kata/53dbd5315a3c69eed20002dd
# List Filtering

def filter_list(l):
    res = []
    for v in l:
        if not isinstance(v, str):
            res.append(v)
    return res
