countNum = 0
sum = 0
while True:
    value = input("Enter Number: ")
    if value.upper() == "DONE":
        break
    else:
        try:
            number = float(value)
            countNum += 1
            sum += number
        except:
            print("Invalid Input")
            continue

print("Sum of Number" , sum)
print("Numbers count:" , countNum)
print("Average" , sum/countNum)