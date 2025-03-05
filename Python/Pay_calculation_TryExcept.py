hours = input("Enter number of hours: ")
rate = input("Enter rate: ")
try: 
    hours = float(hours)
    rate = float(rate)
    pay = hours * rate
    print("Payment: R",pay)
except:
    print("Please enter a numeric input")

