# Phone Directory
# https://www.codewars.com/kata/56baeae7022c16dd7400086e

def phone(strng, num):
    import re
    result = re.findall(num, strng)
    lenth = len(result)
    if lenth > 1:
        return f'Error => Too many people: {num}'
    if lenth == 1:
        for v in strng.split('\n'):
            if num in v:
                result = re.findall(r'<.+>', v)
                if result:
                    name = result[0]
                    name = name.replace('<', '')
                    name = name.replace('>', '')
                    v = re.sub(r'<.+>', '', v)
                address = ''
                for p in v.split(' '):
                    if not num in p:
                        address += f'{p} '
                address = re.sub(r'[_/;,]', ' ', address)
                address = re.sub(r'\s+', ' ', address)
                address = address.strip()
                return f'Phone => {num}, Name => {name}, Address => {address}'
    return f'Error => Not found: {num}'
