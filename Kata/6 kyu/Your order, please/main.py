# Your order, please
# https://www.codewars.com/kata/55c45be3b2079eccff00010f

def order(sentence):
    dic = {}
    data = sentence.split(' ')
    for v in data:
        for s in v:
            if s.isdigit():
                dic[int(s)] = v
                break
    res = []
    for k, v in sorted(dic.items()):
        res.append(v)
    return ' '.join(res)
