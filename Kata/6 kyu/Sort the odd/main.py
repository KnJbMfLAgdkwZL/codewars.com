# Sort the odd
# https://www.codewars.com/kata/578aa45ee9fd15ff4600090d

def sort_array(source_array):
    odd = {}
    for i, v in enumerate(source_array):
        if v % 2 != 0:
            odd[i] = v
    import operator
    s_odd = sorted(odd.items(), key=operator.itemgetter(1))
    i = 0
    for k, v in odd.items():
        source_array[k] = s_odd[i][1]
        i += 1
    return source_array
