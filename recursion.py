# -*- coding: utf-8 -*-
"""
Created on Mon Dec 23 20:27:50 2024

@author: Admin
"""

def count(n):
    print(n, end=" ")
    if n <= 1 :
        return 
    else:
        count(n-1)

n = 5
count(n)
print("============================")

def fact(n):
    print(n, end=" ")
    if n==1:
        return 1
    else:
        return n*fact(n-1)
print(fact(n))
print('=================================')

a = list(range(1, 11))
t = 1
def find(a, t):
    if a[0] == t:
        return f"target number {a[0]}"
    else:
        a.pop(0)
        return find(a, t)
print(find(a, t))

def divide_qonquer(a, b):
    if b == 0:
        return a 
    else:
        return divide_qonquer(b, a % b)  

a, b = 150, 25
gcd = divide_qonquer(a, b)
print(f"kvadrathoi kalontarin: {gcd}")
