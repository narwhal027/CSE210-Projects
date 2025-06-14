# Prompt for grade
number = int(input("Please enter a positive number: "))

# Initialize sum
sum = 0

# Count it up
for count in range(1, number):
    sum += count
    print(f"{sum} += {count}")

# Report
print("The sum is:", sum)