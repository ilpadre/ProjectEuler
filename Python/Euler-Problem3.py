# Problem 3
import math

def IsPrimeByTrialDivision(prime):

   isPrime = 'true'
   if prime != 2:
       if prime % 2 != 0:
           bound = math.ceil(math.sqrt(prime))
           for i in range(3,bound):
               if prime % i == 0:
                   isPrime = 'false'
                   break;
       else:
           isPrime = 'false'

   return isPrime




def findPrimesUpTo(upperBound):

    primes = []
    for i in range(2, math.ceil(math.sqrt(upperBound))):
        if IsPrimeByTrialDivision(i):
            primes.append(i)
    print(primes)
    return primes


primeList = findPrimesUpTo(5915587277)
print(max(primeList))









