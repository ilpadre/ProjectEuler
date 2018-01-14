# Problem 2

x1 = 0;
x2 = 1;
totalSum = 0;

while (x2 < 4000000):
    temp = x2;
    x2 += x1;
    x1 = temp;
    if (x2%2 == 0):
        totalSum += x2
print(x2)
