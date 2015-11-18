# simple program to calculate the balance on your credit card

# balance
balance = float(raw_input("Enter the outstanding balance on your credit card: "))
# annual interest rate
annual_int_rate = float(raw_input("Enter the annual credit card interest rate as a decimal: "))
# minimum monthly payment rate
min_monthly_payment_rate = float(raw_input("Enter the minimum monthly payment rate as a decimal: "))

# monthly interest rate
monthly_int_rate = annual_int_rate/12

# initialize number of months and total amount paid
num_months = 1
total_paid = 0

while num_months <= 12:
    # minimum monthly payment of balance at start of the month
    # round to nearest hundredths
    min_pay = round(min_monthly_payment_rate * balance,2)
    total_paid += min_pay

    # amount of monthly payment that goes to interest
    int_paid = round(monthly_int_rate * balance,2)

    # amount of principal paid off
    prin_paid = min_pay - int_paid

    # subtract monthly payment from outstanding balance
    balance -= prin_paid

    print("Month:%s" % num_months)
    print("Minimum monthly payment:%s" % min_pay)
    print("Remaining balance:%s" % balance)

    # new month
    num_months += 1

print("RESULT")
print("Total amount paid:%s" % total_paid)
print("Remaining balance:%s" % balance)
