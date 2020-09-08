import numpy as np
import matplotlib 
from matplotlib import pyplot as plt
import math

epsilon = 0.001
xline=[]
yline=[]
def f(x):
    return math.pow(x,6) - 5*math.pow(x,3)-2
def find (a,b):
    k=0
    while (b-a>=epsilon):
        c = (a + b) / 2
        if f(a) > 0 and f(c) > 0 or f(a) < 0 and f(c) < 0:
            a = c
        else:
            b = c
    return print((a+b)/2)
print("x1")
find(-1,0)
print("x2")
find(1.5,2)

for x in range(-4, 4):
    y = f(x)
    x=x+0.05
    yline.append(y)
    xline.append(x)
plt.plot(xline,yline)
plt.grid()
plt.ylim([-20, 20])
plt.show() 