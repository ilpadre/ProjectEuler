# Problem 1
totalSum = 0
for x in range(1, 1000):
    if x % 3 == 0 or x % 5 == 0:
        totalSum = totalSum + x
print(totalSum)
