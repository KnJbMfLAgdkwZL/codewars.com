# https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa
# Categorize New Member

def openOrSenior(data):
    res = []
    for v in data:
        if v[0] >= 55 and v[1] > 7:
            res.append("Senior")
        else:
            res.append("Open")
    return res
