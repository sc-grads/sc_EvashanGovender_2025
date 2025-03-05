maxNum = None
num = [22,34,55,44,32,756,43,76]
for x in num:
    if maxNum == None:
        maxNum = x
    elif x > maxNum:
        maxNum = x

print("Highest Number is: " ,maxNum)