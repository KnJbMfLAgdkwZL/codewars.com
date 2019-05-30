# The Supermarket Queue
# https://www.codewars.com/kata/57b06f90e298a7b53d000a86

def queue_time(customers, n):
    time = 0
    kiosk = []
    customers.reverse()
    while len(kiosk) or len(customers):
        while len(kiosk) < n and len(customers):
            kiosk.append(customers.pop())
        for i, k in enumerate(kiosk):
            kiosk[i] -= 1
        i = 0
        while i < len(kiosk):
            if kiosk[i] <= 0:
                kiosk.pop(i)
                i = 0
            else:
                i += 1
        time += 1
    return time
